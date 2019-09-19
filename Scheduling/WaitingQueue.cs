using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class WaitingQueue : Queue
    {
        private int maxSize;
        private int remainingSize;
        private static WaitingQueue thisQueue;
        private WaitingQueue(int maxSize) {
            this.maxSize = maxSize;
            remainingSize = maxSize;
        }
        public static WaitingQueue createWaitingQueue(int maxSize) {
            if(thisQueue == null) {
                thisQueue = new WaitingQueue(maxSize);
            }
            return thisQueue;
        }
        public override void addQueue(Process p)
        {
            if(remainingSize>p.getSize()) {
                queue.Insert(0,p);
                remainingSize -= p.getSize();
            }
            else {
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }
            
        }
        public override int getRemainingSize()
        {
            return remainingSize;
        }
        public override void removeProcess(Process p)
        {
            remainingSize += p.getSize();
            queue.Remove(p);
        }
    }
}
