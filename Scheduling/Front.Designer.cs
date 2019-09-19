namespace Scheduling
{
    partial class form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.arrivalTimeTxt = new System.Windows.Forms.TextBox();
            this.ioTimeTxt = new System.Windows.Forms.TextBox();
            this.measuredTimeTxt = new System.Windows.Forms.TextBox();
            this.priorityTxt = new System.Windows.Forms.TextBox();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.addProcessBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.threadEnabledTxt = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arrival Time(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "IO Require Time(ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Measured Time(ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Process Priority(num)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Process Size(num)";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(226, 45);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(141, 22);
            this.nameTxt.TabIndex = 7;
            // 
            // arrivalTimeTxt
            // 
            this.arrivalTimeTxt.Location = new System.Drawing.Point(226, 262);
            this.arrivalTimeTxt.Name = "arrivalTimeTxt";
            this.arrivalTimeTxt.Size = new System.Drawing.Size(141, 22);
            this.arrivalTimeTxt.TabIndex = 8;
            // 
            // ioTimeTxt
            // 
            this.ioTimeTxt.Location = new System.Drawing.Point(226, 216);
            this.ioTimeTxt.Name = "ioTimeTxt";
            this.ioTimeTxt.Size = new System.Drawing.Size(141, 22);
            this.ioTimeTxt.TabIndex = 9;
            // 
            // measuredTimeTxt
            // 
            this.measuredTimeTxt.Location = new System.Drawing.Point(226, 170);
            this.measuredTimeTxt.Name = "measuredTimeTxt";
            this.measuredTimeTxt.Size = new System.Drawing.Size(141, 22);
            this.measuredTimeTxt.TabIndex = 10;
            // 
            // priorityTxt
            // 
            this.priorityTxt.Location = new System.Drawing.Point(226, 127);
            this.priorityTxt.Name = "priorityTxt";
            this.priorityTxt.Size = new System.Drawing.Size(141, 22);
            this.priorityTxt.TabIndex = 11;
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(226, 85);
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(141, 22);
            this.sizeTxt.TabIndex = 12;
            // 
            // addProcessBtn
            // 
            this.addProcessBtn.Location = new System.Drawing.Point(226, 362);
            this.addProcessBtn.Name = "addProcessBtn";
            this.addProcessBtn.Size = new System.Drawing.Size(141, 23);
            this.addProcessBtn.TabIndex = 13;
            this.addProcessBtn.Text = "Add This Process";
            this.addProcessBtn.UseVisualStyleBackColor = true;
            this.addProcessBtn.Click += new System.EventHandler(this.addProcessBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(955, 577);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Thread Enabled(t/f)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // threadEnabledTxt
            // 
            this.threadEnabledTxt.Location = new System.Drawing.Point(226, 305);
            this.threadEnabledTxt.Name = "threadEnabledTxt";
            this.threadEnabledTxt.Size = new System.Drawing.Size(141, 22);
            this.threadEnabledTxt.TabIndex = 16;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(426, 50);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(0, 17);
            this.descriptionLbl.TabIndex = 17;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 695);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.threadEnabledTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.addProcessBtn);
            this.Controls.Add(this.sizeTxt);
            this.Controls.Add(this.priorityTxt);
            this.Controls.Add(this.measuredTimeTxt);
            this.Controls.Add(this.ioTimeTxt);
            this.Controls.Add(this.arrivalTimeTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form";
            this.Text = "Front";
            this.Load += new System.EventHandler(this.Front_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox arrivalTimeTxt;
        private System.Windows.Forms.TextBox ioTimeTxt;
        private System.Windows.Forms.TextBox measuredTimeTxt;
        private System.Windows.Forms.TextBox priorityTxt;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.Button addProcessBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox threadEnabledTxt;
        private System.Windows.Forms.Label descriptionLbl;
    }
}