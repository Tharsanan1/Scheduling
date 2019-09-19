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
    public partial class form : Form
    {
        DataTable table;
        int count;
        public form()
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("Process Name",typeof(string));
            table.Columns.Add("Size", typeof(int));
            table.Columns.Add("Priority", typeof(int));
            table.Columns.Add("Measured Time", typeof(int));
            table.Columns.Add("IO Require Time", typeof(int));
            table.Columns.Add("Arrival Time", typeof(int));
            table.Columns.Add("ThreadEnabled", typeof(string));
            dataGridView1.DataSource = table;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            nameTxt.Text = "p1";
            sizeTxt.Text = "200";
            priorityTxt.Text = "5";
            measuredTimeTxt.Text = "200";
            ioTimeTxt.Text = "50";
            arrivalTimeTxt.Text = "0";
            count = 1;
            addThisToDescription();

        }
        private void addThisToDescription() {
            descriptionLbl.Text = "WELCOME TO OUR OS SCHEDULING SIMULATION APPLICATION.\n\n\nYou can add processes at the begining or while program running.\n\nYou have to give some basic informations about process to create a process.\n\nIf you enable thread to a process for IO you can see the funtionalities of a multithreaded program.\n\nYou can add a process by clicking 'add process' button.\n\nIf you dont give any datas about a process it will create a process with default value.\n\nAfter creation of processes you can start the simulation by clicking 'start' button.\n\nYou will see functionalities of scheduling in next window.";
        }
        private void Front_Load(object sender, EventArgs e)
        {

        }

        private void addProcessBtn_Click(object sender, EventArgs e)
        {
            count++;
            table.Rows.Add(nameTxt.Text, int.Parse(sizeTxt.Text),int.Parse(priorityTxt.Text),int.Parse(measuredTimeTxt.Text),int.Parse(ioTimeTxt.Text),int.Parse(arrivalTimeTxt.Text),threadEnabledTxt.Text);
            this.dataGridView1.Sort(this.dataGridView1.Columns["Arrival Time"], ListSortDirection.Ascending);
            dataGridView1.Refresh();
            nameTxt.Text = "p"+count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(Program.createGui).Start();
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                if (row.Cells[0].Value == null) break;
                string name = row.Cells[0].Value.ToString();
                bool threadEnabled = false;
                if(row.Cells[6].Value.ToString() == "t") {
                    threadEnabled = true;
                }
                PendingProcess tempProc = new PendingProcess(row.Cells[0].Value.ToString(), (int)row.Cells[2].Value, (int)row.Cells[3].Value, (int)row.Cells[1].Value, (int)row.Cells[4].Value, (int)row.Cells[5].Value,threadEnabled,false);
                Program.agingHandler.addPendingProcess(tempProc);
                Program.agingHandler.startAging();
            }
            
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
