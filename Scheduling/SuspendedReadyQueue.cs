using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class SuspendedReadyQueue : Queue
    {
        
        private static SuspendedReadyQueue thisClass;
        private SuspendedReadyQueue() {
            queue = new List<Process>();
        }
        public static SuspendedReadyQueue createSuspendedReadyqueue() {
            if(thisClass==null) {
                    thisClass = new SuspendedReadyQueue();
                
            }
            return thisClass;
        }
        
        
        


    }
}
