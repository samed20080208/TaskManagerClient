namespace TaskManagerClient
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        private void InitializeComponent()
        {
            txtOutput = new TextBox();
            btnGetProcesses = new Button();
            btnKillProcess = new Button();
            btnRunProcess = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(13, 45);
            txtOutput.Margin = new Padding(4, 3, 4, 3);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(411, 317);
            txtOutput.TabIndex = 2;
            // 
            // btnGetProcesses
            // 
            btnGetProcesses.Location = new Point(302, 368);
            btnGetProcesses.Margin = new Padding(4, 3, 4, 3);
            btnGetProcesses.Name = "btnGetProcesses";
            btnGetProcesses.Size = new Size(122, 60);
            btnGetProcesses.TabIndex = 3;
            btnGetProcesses.Text = "Get All";
            btnGetProcesses.UseVisualStyleBackColor = true;
            btnGetProcesses.Click += btnGetProcesses_Click;
            // 
            // btnKillProcess
            // 
            btnKillProcess.Location = new Point(159, 368);
            btnKillProcess.Margin = new Padding(4, 3, 4, 3);
            btnKillProcess.Name = "btnKillProcess";
            btnKillProcess.Size = new Size(124, 60);
            btnKillProcess.TabIndex = 5;
            btnKillProcess.Text = "Kill";
            btnKillProcess.UseVisualStyleBackColor = true;
            btnKillProcess.Click += btnKillProcess_Click;
            // 
            // btnRunProcess
            // 
            btnRunProcess.Location = new Point(13, 368);
            btnRunProcess.Margin = new Padding(4, 3, 4, 3);
            btnRunProcess.Name = "btnRunProcess";
            btnRunProcess.Size = new Size(124, 60);
            btnRunProcess.TabIndex = 7;
            btnRunProcess.Text = "Post";
            btnRunProcess.UseVisualStyleBackColor = true;
            btnRunProcess.Click += btnRunProcess_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 12);
            button1.Name = "button1";
            button1.Size = new Size(424, 27);
            button1.TabIndex = 8;
            button1.Text = "Join";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 440);
            Controls.Add(button1);
            Controls.Add(btnRunProcess);
            Controls.Add(btnKillProcess);
            Controls.Add(btnGetProcesses);
            Controls.Add(txtOutput);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Task Manager Client";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGetProcesses;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.Button btnRunProcess;
        private Button button1;
    }
}
