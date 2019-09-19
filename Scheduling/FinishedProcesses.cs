using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class FinishedProcesses
    {
        List<Process> finishedProcessesList;
        public FinishedProcesses() {
            finishedProcessesList = new List<Process>();
        }
        public void addProcess(Process p) {
            finishedProcessesList.Add(p);
        }
        public int getLength() {
            return finishedProcessesList.Count();
        }
    }
}
