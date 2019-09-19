using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Scheduling
{
    class AgingHandler
    {
        List<Process> activatedProcesses;
        List<Queue> queues;
        List<PendingProcess> pendingProcessesQueue;
        Timer timer;
        Timer timer1;
        int count;
        int count1;
        private int interval;
        public AgingHandler() {
            interval = 1000;
            activatedProcesses = new List<Process>();
            queues = new List<Queue>();
            pendingProcessesQueue = new List<PendingProcess>();
            timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(onTimeEvent);
            timer.Interval = 10;
            timer1 = new Timer();
            timer1.Elapsed += new ElapsedEventHandler(onTimeEvent1);
            timer1.Interval = interval;

        }
        public void slowDown()
        {
            interval = interval * 10;
            timer1.Enabled = false;
            timer1.Interval = interval;
            timer1.Enabled = true;
        }
        public void resetTimer()
        {
            interval = 1000;
            timer1.Enabled = false;
            timer1.Interval = interval;
            timer1.Enabled = true;
        }
        public void startAging() {
            timer.Enabled = true;
            timer1.Enabled = true;
        }
        public void addQueue(Queue q) {
            queues.Add(q);
        }
        public void addPendingProcess(PendingProcess p) {
            pendingProcessesQueue.Add(p);
        }
        public void addProcess(Process p) {
            activatedProcesses.Add(p);
        }
        public List<Queue> getQueues() {
            return queues;
        }
        public void removeProcess(Process p) {
            activatedProcesses.Remove(p);
        }
        public void checkForPendingProcess() {
            
            if (pendingProcessesQueue.Count()>0) {
                
                
                if (pendingProcessesQueue[0].getArrivalTime() <= count1) {
                    PendingProcess tempP = pendingProcessesQueue[0];
                    pendingProcessesQueue.Remove(tempP);
                    new Process(tempP.getName(), tempP.getPriority(), tempP.getMeasuredTime(), tempP.getSize(), tempP.getIOTime(), tempP.getThreadEnabled(), tempP.getIsDuplicateForIO());
                }
            }
        }
        public void onTimeEvent1(object source, ElapsedEventArgs e)
        {
            count1++;
            if (Program.newGui != null)
            {
                Program.newGui.updateTime((count1).ToString() + "s");
                //Console.Beep();
            }
        }
        public void onTimeEvent(object source, ElapsedEventArgs e) {
            count++;
            lock (Program.o)
            {
                checkForPendingProcess();
                for (int i = 0; i < activatedProcesses.Count(); i++)
                {
                    activatedProcesses.ElementAt(i).increaseIOWaitingTime();
                    activatedProcesses.ElementAt(i).updatePriority();
                    
                }
                for (int j = 0; j < queues.Count(); j++)
                {
                    if (queues.ElementAt(j).GetType() != Program.readyQueue.GetType())
                    {
                        queues.ElementAt(j).sortThisQueue(queues.ElementAt(j).getQueue());
                    }
                    
                    //foreach(Process p in queues.ElementAt(j).getQueue().ToList()){
                    //    Console.Write(p.getName()+" "+p.getMeasuredPriority() + " ");
                    //}

                    //Console.WriteLine();
                }
                if (Program.newGui != null) {
                    Program.newGui.guiHandler();
                }
            }
        }
    }
}
