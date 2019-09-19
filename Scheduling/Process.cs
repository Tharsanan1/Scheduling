using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class Process
    {
        private int priority;
        private double measuredPriority;
        private int sizePriority;
        private int timeInQueue;
        private int measuredTime;
        private int remainingTime;
        private int PCAddress;
        private int size;
        private int arrivalTime;
        private int IORemainingTime;
        private int processedTime;
        private int breakProperty;
        private bool isReady;
        private bool isWaiting;
        private bool isBlockedAndSuspended;
        private bool isBlockedAndReady;
        private bool isRunning;
        private bool finished;
        private bool isNew;
        private bool waitingForIO;
        private string name;
        private bool threadEnabled;
        private bool isDuplicateForIO;
        private List<int> iORequiredTimes;

        public Process(string name,int priority, int measuredTime, int size, int time,bool threadEnabled, bool isDuplicateForIO) { 
            this.priority = priority;
            this.measuredTime = measuredTime;
            this.sizePriority = 10 / measuredTime;
            this.processedTime = 0;
            this.size = size;
            this.name = name;
            this.isDuplicateForIO = isDuplicateForIO;
            this.threadEnabled = threadEnabled;
            isNew = true;
            timeInQueue = 0;
            remainingTime = measuredTime;
            iORequiredTimes = new List<int>();
            iORequiredTimes.Add(time);
            Program.agingHandler.addProcess(this);
            if (!isDuplicateForIO)
            {
                Program.newQueue.addQueue(this);
            }
            breakProperty = Program.cpu.getCPUBreakIntervel();
            measuredPriority = ((double)(priority + timeInQueue + sizePriority) / ((double)remainingTime));
            Console.WriteLine("process created and new queue lenght: "+ Program.newQueue.getQueue().Count());


        }
        
        public bool getThreadEnabled()
        {
            return threadEnabled;
        }
        public bool getIsDuplicateForIO()
        {
            return isDuplicateForIO;
        }
        public string getName() {
            return name;
        }
        public int getPriority() {
            return priority;
        }
        public void removeIORequiredtime() {
            iORequiredTimes.RemoveAt(0);
        }
        public void increaseIOWaitingTime() {
            timeInQueue++;
        }
        public void setTimeInQueue() {
            timeInQueue = 0;
        }
        public List<int> getIORequiredTimesQueue() {
            return iORequiredTimes;
        }
        public int getRemainingTime() {
            return remainingTime;
        }

        public double getMeasuredPriority() {
            return measuredPriority;
        }
        public void updatePriority() {
            
            remainingTime = measuredTime - processedTime;
            
            if(remainingTime <=0) {
                remainingTime = 1;
            }
            measuredPriority = ((double)(priority + (timeInQueue*10) + sizePriority) / ((double)remainingTime));
        }
        public int getSize() {
            return size;
        }
        public void IOTiming() { 

        }
        public int getIOReamainingTime() {
            return IORemainingTime;
        }
        public void setIOReamainingTime(int i) {
            IORemainingTime = i;
        }
        public int getProcessedTime()
        {
            return processedTime;
        }
        public void setProcessedTime(int time) {
            processedTime = time;
        }
        public int getMeasuredTime() {
            return measuredTime;
        }



    }
}
