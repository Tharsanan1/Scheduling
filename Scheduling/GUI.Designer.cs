namespace Scheduling
{
    partial class GUI
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
            this.CreateProcessButton = new System.Windows.Forms.Button();
            this.newQueuePanel = new System.Windows.Forms.Panel();
            this.readyqueuePanel = new System.Windows.Forms.Panel();
            this.blockedQueuePanel = new System.Windows.Forms.Panel();
            this.readySuspendedPanel = new System.Windows.Forms.Panel();
            this.blockedSuspendedPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cpuSpace = new System.Windows.Forms.Panel();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.priorityTxt = new System.Windows.Forms.TextBox();
            this.ioRequiredTimeTxt = new System.Windows.Forms.TextBox();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.measuredTimeTxt = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.currentProcessLbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.processedTimeLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slowDownBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.GuiPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateProcessButton
            // 
            this.CreateProcessButton.Location = new System.Drawing.Point(637, 569);
            this.CreateProcessButton.Name = "CreateProcessButton";
            this.CreateProcessButton.Size = new System.Drawing.Size(127, 23);
            this.CreateProcessButton.TabIndex = 0;
            this.CreateProcessButton.Text = "Create Process";
            this.CreateProcessButton.UseVisualStyleBackColor = true;
            this.CreateProcessButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newQueuePanel
            // 
            this.newQueuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newQueuePanel.Location = new System.Drawing.Point(291, 85);
            this.newQueuePanel.Name = "newQueuePanel";
            this.newQueuePanel.Size = new System.Drawing.Size(823, 43);
            this.newQueuePanel.TabIndex = 1;
            // 
            // readyqueuePanel
            // 
            this.readyqueuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readyqueuePanel.Location = new System.Drawing.Point(291, 167);
            this.readyqueuePanel.Name = "readyqueuePanel";
            this.readyqueuePanel.Size = new System.Drawing.Size(823, 43);
            this.readyqueuePanel.TabIndex = 2;
            // 
            // blockedQueuePanel
            // 
            this.blockedQueuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockedQueuePanel.Location = new System.Drawing.Point(291, 246);
            this.blockedQueuePanel.Name = "blockedQueuePanel";
            this.blockedQueuePanel.Size = new System.Drawing.Size(823, 43);
            this.blockedQueuePanel.TabIndex = 3;
            // 
            // readySuspendedPanel
            // 
            this.readySuspendedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readySuspendedPanel.Location = new System.Drawing.Point(291, 332);
            this.readySuspendedPanel.Name = "readySuspendedPanel";
            this.readySuspendedPanel.Size = new System.Drawing.Size(823, 45);
            this.readySuspendedPanel.TabIndex = 4;
            // 
            // blockedSuspendedPanel
            // 
            this.blockedSuspendedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockedSuspendedPanel.Location = new System.Drawing.Point(291, 419);
            this.blockedSuspendedPanel.Name = "blockedSuspendedPanel";
            this.blockedSuspendedPanel.Size = new System.Drawing.Size(823, 45);
            this.blockedSuspendedPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Blocked Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "ReadySuspended";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "BlockedSuspended";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ready Queue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPU";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cpuSpace
            // 
            this.cpuSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cpuSpace.Location = new System.Drawing.Point(71, 189);
            this.cpuSpace.Name = "cpuSpace";
            this.cpuSpace.Size = new System.Drawing.Size(128, 43);
            this.cpuSpace.TabIndex = 12;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(507, 520);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 22);
            this.nameTxt.TabIndex = 13;
            // 
            // priorityTxt
            // 
            this.priorityTxt.Location = new System.Drawing.Point(507, 569);
            this.priorityTxt.Name = "priorityTxt";
            this.priorityTxt.Size = new System.Drawing.Size(100, 22);
            this.priorityTxt.TabIndex = 14;
            // 
            // ioRequiredTimeTxt
            // 
            this.ioRequiredTimeTxt.Location = new System.Drawing.Point(507, 596);
            this.ioRequiredTimeTxt.Name = "ioRequiredTimeTxt";
            this.ioRequiredTimeTxt.Size = new System.Drawing.Size(100, 22);
            this.ioRequiredTimeTxt.TabIndex = 15;
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(507, 544);
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(100, 22);
            this.sizeTxt.TabIndex = 16;
            // 
            // measuredTimeTxt
            // 
            this.measuredTimeTxt.Location = new System.Drawing.Point(507, 623);
            this.measuredTimeTxt.Name = "measuredTimeTxt";
            this.measuredTimeTxt.Size = new System.Drawing.Size(100, 22);
            this.measuredTimeTxt.TabIndex = 17;
            this.measuredTimeTxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(288, 525);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 18;
            this.Name.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Measured time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Time To IO Waiting";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Priority";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Time :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Current Process";
            // 
            // currentProcessLbl
            // 
            this.currentProcessLbl.AutoSize = true;
            this.currentProcessLbl.Location = new System.Drawing.Point(198, 102);
            this.currentProcessLbl.Name = "currentProcessLbl";
            this.currentProcessLbl.Size = new System.Drawing.Size(0, 17);
            this.currentProcessLbl.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Processed Time";
            // 
            // processedTimeLbl
            // 
            this.processedTimeLbl.AutoSize = true;
            this.processedTimeLbl.Location = new System.Drawing.Point(198, 139);
            this.processedTimeLbl.Name = "processedTimeLbl";
            this.processedTimeLbl.Size = new System.Drawing.Size(0, 17);
            this.processedTimeLbl.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.processedTimeLbl);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.currentProcessLbl);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cpuSpace);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1164, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 318);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // slowDownBtn
            // 
            this.slowDownBtn.Location = new System.Drawing.Point(1235, 506);
            this.slowDownBtn.Name = "slowDownBtn";
            this.slowDownBtn.Size = new System.Drawing.Size(128, 23);
            this.slowDownBtn.TabIndex = 30;
            this.slowDownBtn.Text = "Slow Down";
            this.slowDownBtn.UseVisualStyleBackColor = true;
            this.slowDownBtn.Click += new System.EventHandler(this.slowDownBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(1235, 560);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(127, 23);
            this.resetBtn.TabIndex = 31;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // GuiPanel
            // 
            this.GuiPanel.Location = new System.Drawing.Point(291, 24);
            this.GuiPanel.Name = "GuiPanel";
            this.GuiPanel.Size = new System.Drawing.Size(1378, 28);
            this.GuiPanel.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Processes in cpu";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 728);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GuiPanel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.slowDownBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.measuredTimeTxt);
            this.Controls.Add(this.sizeTxt);
            this.Controls.Add(this.ioRequiredTimeTxt);
            this.Controls.Add(this.priorityTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blockedSuspendedPanel);
            this.Controls.Add(this.readySuspendedPanel);
            this.Controls.Add(this.blockedQueuePanel);
            this.Controls.Add(this.readyqueuePanel);
            this.Controls.Add(this.newQueuePanel);
            this.Controls.Add(this.CreateProcessButton);
            //this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateProcessButton;
        private System.Windows.Forms.Panel newQueuePanel;
        private System.Windows.Forms.Panel readyqueuePanel;
        private System.Windows.Forms.Panel blockedQueuePanel;
        private System.Windows.Forms.Panel readySuspendedPanel;
        private System.Windows.Forms.Panel blockedSuspendedPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel cpuSpace;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox priorityTxt;
        private System.Windows.Forms.TextBox ioRequiredTimeTxt;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.TextBox measuredTimeTxt;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label currentProcessLbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label processedTimeLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button slowDownBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel GuiPanel;
        private System.Windows.Forms.Label label14;
    }
}