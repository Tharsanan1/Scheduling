using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Scheduling
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateProcessButton.Enabled = false;
            new Thread(createProcess).Start();
            CreateProcessButton.Enabled = true;
        }
        public void createProcess() {
            
                lock (Program.o)
                {
                    try
                    {
                        new Process(nameTxt.Text.ToString(), int.Parse(priorityTxt.Text.ToString()), int.Parse(measuredTimeTxt.Text.ToString()), int.Parse(sizeTxt.Text.ToString()), int.Parse(ioRequiredTimeTxt.Text.ToString()),false,false);
                    }
                    catch {

                    }
                    }

            
            
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }
        public void updateTime(string txt) {
            if (label12.InvokeRequired)
            {
                label12.Invoke((MethodInvoker)delegate ()
                {
                    updateTime(txt);
                });
            }
            else
            {
                label12.Text = txt;
            }
            
        }
        public void guiHandler()
        {

            
            int tempInt = 0;
            foreach (Queue q in Program.agingHandler.getQueues())
            {
                tempInt++;
                Panel tempP;
                string stringForLabel;
                Label l;
                if (q.GetType() == Program.newQueue.GetType()) tempP = newQueuePanel;
                else if (q.GetType() == Program.readyQueue.GetType()) tempP = readyqueuePanel;
                else if (q.GetType() == Program.waitingQueue.GetType()) tempP = blockedQueuePanel;
                else if (q.GetType() == Program.suspendedReadyQueue.GetType()) tempP = readySuspendedPanel;
                else tempP = blockedSuspendedPanel;
                int lenght = tempP.Width - 30;
                //tempP.Controls.Clear();
                clearPanel(tempP);
                foreach (Process p in q.getQueue().ToList())
                {

                    stringForLabel = p.getName();
                    l = new Label();
                    l.Text = stringForLabel;
                    l.BackColor = Color.Black;
                    l.ForeColor = Color.White;
                    l.Location = new Point(lenght, 4);
                    lenght -= ( 30);
                    l.AutoSize = true;
                    addLabel(l, tempP);
                    //tempP.Controls.Add(l);
                }
            }
            clearPanel(cpuSpace);
            if (Program.cpu.getProcess() != null && !Program.cpu.isIdle())
            {
                Label lbl = new Label();
                lbl.Text = Program.cpu.getProcess().getName();
                lbl.BackColor = Color.Black;
                lbl.ForeColor = Color.White;
                lbl.Location = new Point(4, 4);
                lbl.AutoSize = true;
                Label lbl1 = new Label();
                lbl1.Text = Program.cpu.getProcess().getProcessedTime().ToString();
                lbl1.BackColor = Color.Black;
                lbl1.ForeColor = Color.White;
                lbl1.Location = new Point(30, 4);
                lbl1.AutoSize = true;
                //addLabel(lbl1, cpuSpace);
                addLabel(lbl, cpuSpace);
                writeLbl(currentProcessLbl, Program.cpu.getProcess().getName());
                writeLbl(processedTimeLbl, Program.cpu.getProcess().getProcessedTime().ToString()+"ms");
                //currentProcessLbl.Text = Program.cpu.getProcess().getName();
                //processedTimeLbl.Text = Program.cpu.getProcess().getProcessedTime().ToString();
            }
            else {
                writeLbl(currentProcessLbl, "");
                writeLbl(processedTimeLbl, "");
            }
        }
        public void writeLbl(Label l,string s) {
            if (l.InvokeRequired)
            {
                l.Invoke((MethodInvoker)delegate ()
                {
                    writeLbl(l ,s);
                });
            }
            else
            {
                l.Text = s;
            }
        }
        public void addLabel(Label l, Panel p)
            {
                if (p.InvokeRequired)
                {
                    p.Invoke((MethodInvoker)delegate()
                    {
                        addLabel(l, p);
                    });
                }
                else
                {
                p.Controls.Add(l);
                }
            }
         public void clearPanel(Panel p) {
                if (p.InvokeRequired)
                {
                    p.Invoke((MethodInvoker)delegate ()
                    {
                        clearPanel(p);
                    });
                }
                else
                {
                    p.Controls.Clear();
                }
        }
        public void addLabelToGuiPanel(string s, int count) {
            Label lbl = new Label();
            lbl.Text = Program.cpu.getProcess().getName();
            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(count*20, 4);
            lbl.AutoSize = true;
            addLabel(lbl,GuiPanel);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void slowDownBtn_Click(object sender, EventArgs e)
        {
            Program.cpu.slowDown();
            Program.agingHandler.slowDown();
            Program.newIOHandler.slowDown();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Program.newIOHandler.resetTimer();
            Program.cpu.resetTimer();
            Program.agingHandler.resetTimer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

