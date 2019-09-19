using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Scheduling
{
    class OS
    {
        public OS() {
            new Thread(newToReadyHandler).Start();
            new Thread(suspendedBlockedToBlockedHandler).Start();
            new Thread(suspendedReadyToReadyHandler).Start();
            new Thread(readyToRunningHandler).Start();
            Console.WriteLine("Threads created");
        }
        public void createNewProcess(string name,int priority, int measuredTime, int size, int time,bool threadEnabled, bool isDuplicateForIO) {
            Program.newQueue.addQueue(new Process(name,priority,measuredTime,size,time,threadEnabled,isDuplicateForIO));
        }
        public void newToReadyHandler() {
            while (true)
            {
                lock (Program.o)
                {
                    if (Program.newQueue.getQueue().Count() > 0)
                    {
                        for (int i = Program.newQueue.getQueue().Count() - 1; i >= 0; i--)
                        {
                            if (Program.newQueue.getQueue().ElementAt(i).getSize() < Program.readyQueue.getRemainingSize())
                            {
                                Process temp = Program.newQueue.getQueue().ElementAt(i);
                                Program.newQueue.getQueue().RemoveAt(i);
                                Program.readyQueue.addQueue(temp);
                                Console.Write("swapped a process!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                                break;
                            }
                            else if (Program.readyQueue.getQueue().Count()>0) {
                                int tempTotalSize = 0;
                                for(int k=0; k< Program.readyQueue.getQueue().Count();k++) {
                                    if(Program.newQueue.getQueue().ElementAt(i).getMeasuredPriority() <= Program.readyQueue.getQueue().ElementAt(k).getMeasuredPriority()) {
                                        break;
                                    }
                                    tempTotalSize += Program.readyQueue.getQueue().ElementAt(k).getSize();
                                    if(tempTotalSize>= Program.newQueue.getQueue().ElementAt(i).getSize()) {
                                        Console.WriteLine("size of added process that are in ready queue : " + tempTotalSize);
                                        int tempInt = k;
                                        while(tempInt>=0) { 
                                            readyToReadySuspendedHandler(Program.readyQueue.getQueue().ElementAt(0));
                                            tempInt--;
                                            Console.WriteLine("readyQueue Size : "+Program.readyQueue.getRemainingSize());
                                        }
                                        Process temp = Program.newQueue.getQueue().ElementAt(i);
                                        Program.newQueue.getQueue().RemoveAt(i);
                                        Program.readyQueue.addQueue(temp);
                                        Console.Write("swapped a process!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                                        break;
                                    }
                                }
                                //if (Program.newQueue.getQueue().ElementAt(i).getMeasuredPriority() > Program.readyQueue.getQueue().ElementAt(0).getMeasuredPriority())
                                //{
                                //    if (Program.newQueue.getQueue().ElementAt(i).getSize() < Program.readyQueue.getQueue().ElementAt(0).getSize())
                                //    {
                                //        readyToReadySuspendedHandler(Program.readyQueue.getQueue().ElementAt(0));
                                //        Program.readyQueue.addQueue(Program.newQueue.getQueue().ElementAt(i));
                                //        break;
                                //    }
                                //    else { 
                                //        //Console.Write("no process swapped\n"); 
                                //    }
                                //}
                            }
                        }
                    }
                }
            }
        }
        public void readyToRunningHandler()
        {
            while (true)
            {
                lock (Program.o) {
                    if (Program.readyQueue.getQueue().Count() > 0 && Program.cpu.isIdle())
                    {
                        Process temp = Program.readyQueue.getMostPriorityProcess();
                        Program.cpu.loadThisProcess(temp);
                        Program.readyQueue.removeProcess(temp);
                        Program.cpu.setBusy();
                    }
                }
            }
            
        }
        public void runningToReadyHandler() {
            Console.WriteLine("in running to ready");
            Process temp = Program.cpu.getProcess();
            if (Program.readyQueue.getRemainingSize()>temp.getSize()) {
                Program.readyQueue.addQueue(temp);
            }
            else {
                runningToReadySuspendedHandler(temp);
            }
            Program.cpu.setIdle();

        }
        public void readyToReadySuspendedHandler(Process p) {
            Console.WriteLine("readyToReadySuspended");
            Program.readyQueue.removeProcess(p);
            Program.suspendedReadyQueue.addQueue(p);
        }
        public void runningToReadySuspendedHandler(Process p) {
            Console.WriteLine("running to readySuspended");
            Program.suspendedReadyQueue.addQueue(p);
        }
        public void runningToBlockedHandler(Process p) {
            Console.WriteLine("running to Blocked");
            Console.WriteLine(p.getProcessedTime());
            if (p.getSize()<Program.waitingQueue.getRemainingSize()) {
                Program.waitingQueue.addQueue(p);
                
            }
            else {
                bool temp = false;
                for(int i = 0; i<Program.waitingQueue.getQueue().Count(); i++) {
                    if(Program.waitingQueue.getQueue().ElementAt(i).getMeasuredPriority()<p.getMeasuredPriority()) {
                        if(Program.waitingQueue.getQueue().ElementAt(i).getSize()<=p.getSize()) {
                            Process tempProcess = Program.waitingQueue.getQueue().ElementAt(i);
                            blockedToSuspendedBlockedHandler(tempProcess);
                            Program.waitingQueue.addQueue(p);
                            temp = true;
                            break;
                        }
                    }
                }
                if(!temp) {
                    Program.suspendedWaitingQueue.addQueue(p);
                }
            }
            if (!p.getIsDuplicateForIO())
            {
                Program.cpu.setIdle();
            }
        }
        
        public void blockedToSuspendedBlockedHandler(Process p) {
            Console.WriteLine("blocked to suspended");
            Program.waitingQueue.removeProcess(p);
            Program.suspendedWaitingQueue.addQueue(p);
        }
        public void suspendedBlockedToBlockedHandler() {

            while (true)
            {
                lock (Program.o)
                {
                    if (Program.suspendedWaitingQueue.getQueue().Count() > 0)
                    {
                        if (Program.suspendedWaitingQueue.getMostPriorityProcess().getSize() < Program.waitingQueue.getRemainingSize())
                        {
                            Console.WriteLine("swapping process from supendedwaiting to blocked");
                            Process tempP = Program.suspendedWaitingQueue.getMostPriorityProcess();
                            Program.suspendedWaitingQueue.getQueue().Remove(tempP);
                            Program.waitingQueue.addQueue(tempP);
                        }
                    }
                }
            }
        }
        
        public void suspendedReadyToReadyHandler() {
            while (true)
            {
                lock (Program.o)
                {
                    //Console.WriteLine("suspendedReadytoready working");
                    if (Program.suspendedReadyQueue.getQueue().Count() > 0)
                    {
                        for (int i = Program.suspendedReadyQueue.getQueue().Count() - 1; i >= 0; i--)
                        {
                            if (Program.suspendedReadyQueue.getQueue().ElementAt(i).getSize() < Program.readyQueue.getRemainingSize())
                            {
                                Console.WriteLine("swapping process from suspended ready to readyhandler ");
                                Process tempP = Program.suspendedReadyQueue.getQueue().ElementAt(i);
                                Program.suspendedReadyQueue.getQueue().Remove(tempP);
                                Program.readyQueue.addQueue(tempP);
                                break;
                            }
                            else if (Program.readyQueue.getQueue().Count() > 0)
                            {
                                int tempTotalSize = 0;
                                for (int k = 0; k < Program.readyQueue.getQueue().Count(); k++)
                                {
                                    if (Program.suspendedReadyQueue.getQueue().ElementAt(i).getMeasuredPriority() <= Program.readyQueue.getQueue().ElementAt(k).getMeasuredPriority())
                                    {
                                        break;
                                    }
                                    tempTotalSize += Program.readyQueue.getQueue().ElementAt(k).getSize();
                                    if (tempTotalSize >= Program.suspendedReadyQueue.getQueue().ElementAt(i).getSize())
                                    {
                                        Process temp = Program.suspendedReadyQueue.getQueue().ElementAt(i);
                                        int tempInt = k;
                                        while (tempInt >= 0)
                                        {
                                            readyToReadySuspendedHandler(Program.readyQueue.getQueue().ElementAt(0));
                                            tempInt--;
                                            Console.WriteLine("inside suspended to ready while readyQueue remaining size: " + Program.readyQueue.getRemainingSize());
                                        }
                                        
                                        Program.suspendedReadyQueue.getQueue().Remove(temp);
                                        Console.WriteLine("argument was : "+ (tempTotalSize >= Program.suspendedReadyQueue.getQueue().ElementAt(i).getSize()) + " total memory to be swapped : "+tempTotalSize+" this process size: "+ temp.getSize()+"readyQueue remaining size: "+Program.readyQueue.getRemainingSize());

                                        Program.readyQueue.addQueue(temp);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                    
            }
        }
        public void IOFInishedEventHandler(Process p) {
            if(Program.waitingQueue.getQueue().Contains(p)) {
                Program.waitingQueue.removeProcess(p);
                if (p.getIsDuplicateForIO())
                {

                }
                else
                {
                    if (Program.readyQueue.getRemainingSize() > p.getSize())
                    {
                        Program.readyQueue.addQueue(p);
                    }
                    else
                    {
                        Program.suspendedReadyQueue.addQueue(p);
                    }
                }

            }
            else {
                Program.suspendedWaitingQueue.getQueue().Remove(p);
                if (p.getIsDuplicateForIO())
                {

                }
                else
                {
                    Program.suspendedReadyQueue.addQueue(p);
                }
            }
            
        }

    }
}
