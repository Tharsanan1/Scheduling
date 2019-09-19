using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    

    class PendingProcess
    {
        string name;
        int priority;
        int measuredTime;
        int size;
        int ioTime;
        int arrivalTime;
        bool threadEnabled;
        bool isDuplicateForIO;
        public PendingProcess(string name, int priority, int measuredTime, int size, int ioTime,int arrivalTime, bool threadEnabled, bool isDuplicateForIO) {
            this.name = name;
            this.priority = priority;
            this.measuredTime = measuredTime;
            this.size = size;
            this.ioTime = ioTime;
            this.arrivalTime = arrivalTime;
            this.isDuplicateForIO = isDuplicateForIO;
            this.threadEnabled = threadEnabled;
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
        public int getMeasuredTime() {
            return measuredTime;
        }
        public int getSize() {
            return size;
        }
        public int getIOTime() {
            return ioTime;
        }
        public int getArrivalTime() {
            return arrivalTime;
        }
    }
}
