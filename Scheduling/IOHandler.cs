using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class IOHandler                                                     // first in first out type IO.
    {
        private List<Process> iOWaitingProcessesQueue;
        private System.Timers.Timer newTimer;
        private int count;
        private int interval;
        public IOHandler()
        {
            interval = 1;
            iOWaitingProcessesQueue = new List<Process>();
            newTimer = new System.Timers.Timer();
            newTimer.Elapsed += new System.Timers.ElapsedEventHandler(onTimeEvent);
            newTimer.Interval = interval;
            newTimer.Enabled = true;
            count = 0;
        }
        public void slowDown()
        {
            interval = interval * 10;
            newTimer.Enabled = false;
            newTimer.Interval = interval;
            newTimer.Enabled = true;
        }
        public void resetTimer()
        {
            interval = 1;
            newTimer.Enabled = false;
            newTimer.Interval = interval;
            newTimer.Enabled = true;
        }
        public void addToIOWaitingProcessesQueue(Process p)
        {
            iOWaitingProcessesQueue.Add(p);
        }
        public void IOTiming()
        {

        }
        public void onTimeEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            lock (Program.o)
            {
                if (iOWaitingProcessesQueue.Count() > 0)
                {
                    count++;
                    
                    if (count == 100)
                    {
                        
                            Console.WriteLine("a process io has finished");
                            Process tempP = iOWaitingProcessesQueue.ElementAt(0);
                            iOWaitingProcessesQueue.RemoveAt(0);
                            Program.os.IOFInishedEventHandler(tempP);
                            tempP.removeIORequiredtime();
                            count = 0;
                        
                    }
                }
            }
        }
    }
}
