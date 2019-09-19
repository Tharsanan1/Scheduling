using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;


namespace Scheduling
{
    class CPU
    {
        private int processCount;
        private bool idle;
        private Process currentProcess;
        private static CPU cPU;
        private int count;
        private int cPUBreakTimeIntervel;
        System.Timers.Timer newTimer;
        private int interval;
        private CPU(int breakTime) {
            interval = 10;
            idle = true;
            this.cPUBreakTimeIntervel = breakTime;
            newTimer = new System.Timers.Timer();
            newTimer.Elapsed += new ElapsedEventHandler(onTimeEvent);
            newTimer.Interval = interval;
            newTimer.Enabled = true;
            new Thread(perfomeCPU).Start();
            processCount = 0;

        }
        public void slowDown()
        {
            interval = interval * 100;
            newTimer.Enabled = false;
            newTimer.Interval = interval;
            newTimer.Enabled = true;
        }
        public void resetTimer()
        {
            interval = 10;
            newTimer.Enabled = false;
            newTimer.Interval = interval;
            newTimer.Enabled = true;
        }
        public static CPU createCPU(int breakTime) {
            if(cPU == null) {
                cPU = new CPU(breakTime);
            }
            return cPU;
        }
        public int getCPUBreakIntervel() {
            return cPUBreakTimeIntervel;
        }
        public bool isIdle() {
            return idle;
        }
        public void setIdle() {
            idle = true;
        }
        public void setBusy() {
            idle = false;

        }
        public void loadThisProcess(Process p) {
            Console.WriteLine("cpu get a process named "+p.getName());
            currentProcess = p;
            currentProcess.setTimeInQueue();
            count = 0;
            idle = false;
            newTimer.Enabled = true;
            setBusy();
            Program.newGui.addLabelToGuiPanel(p.getName(), processCount);
            processCount++;
            
        }
        public Process getProcess() {
            return currentProcess;
        }
        
        public void onTimeEvent(object source, ElapsedEventArgs e) {
            
                count++;
            
        }
        public void perfomeCPU() { 
            
            while (true) {
                lock (Program.o)
                {
                    if (!isIdle())
                    {
                        
                        if (currentProcess.getIORequiredTimesQueue().Count() > 0)
                        {
                            if (currentProcess.getIORequiredTimesQueue().ElementAt(0) <= currentProcess.getProcessedTime() + count)
                            {
                                if(currentProcess.getThreadEnabled()) {
                                    currentProcess.getIORequiredTimesQueue().RemoveAt(0);
                                    Process thread = new Process(currentProcess.getName()+" t", currentProcess.getPriority(), currentProcess.getMeasuredTime(),currentProcess.getSize(),0,true,true);
                                    Program.os.runningToBlockedHandler(thread);
                                    Program.newIOHandler.addToIOWaitingProcessesQueue(thread);
                                }
                                else {
                                    newTimer.Enabled = false;
                                    Console.WriteLine("Blocked");
                                    Program.os.runningToBlockedHandler(currentProcess);
                                    currentProcess.setProcessedTime(currentProcess.getProcessedTime() + count);
                                    count = 0;
                                    Program.newIOHandler.addToIOWaitingProcessesQueue(currentProcess);

                                    setIdle();
                                }
                                
                            }
                            else
                            {
                                if (currentProcess.getProcessedTime() + count >= currentProcess.getMeasuredTime())
                                {
                                    newTimer.Enabled = false;
                                    Program.finishedProcesses.addProcess(currentProcess);
                                    Program.agingHandler.removeProcess(currentProcess);
                                    currentProcess.setProcessedTime(currentProcess.getProcessedTime() + count);
                                    Console.WriteLine("process finished and processed time = " + currentProcess.getProcessedTime());
                                    count = 0;
                                    
                                    setIdle();
                                }
                                else if (count>=cPUBreakTimeIntervel)
                                {
                                    newTimer.Enabled = false;
                                    Console.WriteLine("time out****************************************** process getout processed time = "+currentProcess.getProcessedTime());
                                    currentProcess.setProcessedTime(currentProcess.getProcessedTime() + count);
                                    count = 0;
                                    Program.os.runningToReadyHandler();
                                    
                                    setIdle();

                                }
                                
                            }

                        }
                        else
                        {
                            if (currentProcess.getProcessedTime() + count >= currentProcess.getMeasuredTime())
                            {
                                newTimer.Enabled = false;
                                Console.WriteLine("finished process");
                                
                                Program.finishedProcesses.addProcess(currentProcess);
                                currentProcess.setProcessedTime(currentProcess.getProcessedTime() + count);
                                count = 0;
                                
                                setIdle();
                            }
                            else if (count >= cPUBreakTimeIntervel )
                            {
                                currentProcess.setProcessedTime(currentProcess.getProcessedTime() + count);
                                Console.WriteLine("time out******************************************process getout processed time = " + currentProcess.getProcessedTime());
                                newTimer.Enabled = false;
                                
                                count = 0;
                                Program.os.runningToReadyHandler();
                                
                                setIdle();
                            }
                            
                        }
                        if (newTimer.Enabled == false)
                        {
                            currentProcess.setTimeInQueue();
                            setIdle();
                        }
                    }
                }
            }
            
        }
    }
}
