using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    abstract class Queue
    {
        protected List<Process> queue;
        public Queue() {
            Program.agingHandler.addQueue(this);
            queue = new List<Process>();
        }
        public virtual void addQueue(Process p)
        {
            Console.WriteLine("process added");
            
            queue.Insert(0,p);
        }
        public List<Process> getQueue() {
            return queue;
        }
        public void reArrangeThisQueue()
        {
            // code for sort the process with respect to measured priority.

        }
        public void updatePriority()
        {
            foreach (Process p in queue)
            {
                p.updatePriority();
            }
        }
        
        public void sortThisQueue(List<Process> list) {
            if (list.Count() > 1)
            {
                
                for(int i= list.Count()-2; i>=0; i--) {
                    for(int j=0; j<=i; j++) {
                        if(list.ElementAt(j).getMeasuredPriority()>list.ElementAt(j+1).getMeasuredPriority()) {
                            Process tempP = list.ElementAt(j);
                            list[j] = list.ElementAt(j + 1);
                            list[j + 1] = tempP;
                        }
                    }
                }
            }

        }
        public Process getMostPriorityProcess() {
            return queue.ElementAt(queue.Count() - 1);
        }
        public virtual int getRemainingSize() {
            return 10000; 
        }
        public virtual void removeProcess(Process p) { }
        
    }
}
