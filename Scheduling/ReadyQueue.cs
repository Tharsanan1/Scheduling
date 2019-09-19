using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class ReadyQueue : Queue
    {
        private int size;
        private int remainingSize;
        public ReadyQueue(int size) {
            this.remainingSize = size;
        }
        public override int getRemainingSize() {
            return remainingSize;
        }
        public override void addQueue(Process p)
        {
            if (remainingSize > p.getSize())
            {
                queue.Insert(0,p);
                remainingSize -= p.getSize();
                Console.WriteLine("successfully added");
            }
            else {
                Console.WriteLine("not enough space process size : "+p.getSize()+" remain : "+Program.readyQueue.getRemainingSize());
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }

        }
        public override void removeProcess(Process p) {
            remainingSize += p.getSize();
            queue.Remove(p);
        }
        
    }
}
