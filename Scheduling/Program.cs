using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace Scheduling
{
    class Program
    {
        public static Queue newQueue;
        public static Queue readyQueue;
        public static Queue suspendedReadyQueue;
        public static Queue waitingQueue;
        public static Queue suspendedWaitingQueue;
        public static OS os;
        public static CPU cpu;
        public static IOHandler newIOHandler;
        public static FinishedProcesses finishedProcesses;
        public static AgingHandler agingHandler;
        public static GUI newGui;
        public static form newFrontPage;
        public static Object o;
        [STAThread]
        static void Main(string[] args)
        {
            o = new object();                                                             // created for lock object
            agingHandler = new AgingHandler();                                            // this will handle aging of processes and sort queues.
            new Thread(createFrontGui).Start();                                           // a thread will create a gui
            cpu = CPU.createCPU(100);                                                     // cpu object will handle all processing of processes.
            newQueue = new NewQueue();                                                    // this queues will contain processes.
            readyQueue = new ReadyQueue(1000);
            suspendedReadyQueue = SuspendedReadyQueue.createSuspendedReadyqueue();
            waitingQueue = WaitingQueue.createWaitingQueue(1000);
            suspendedWaitingQueue = new SupendedWaitingQueue();
            os = new OS();                                                                // this object will handle swapping and dispatching of processes.
            newIOHandler = new IOHandler();                                               // this object wuill handle processes io waiting in the blocked queue
            finishedProcesses = new FinishedProcesses();
        }
        public static void createGui() {                                                  // method to create a form.
            newGui = new GUI();
            newGui.Show();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(newGui);
        }
        public static void createFrontGui()
        {                                                                                 // method to create a form.
            newFrontPage = new form();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(newFrontPage);

        }
        
    }
}
