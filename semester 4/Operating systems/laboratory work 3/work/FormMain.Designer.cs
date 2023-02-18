namespace work
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonListProcesses = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonEnvironment = new System.Windows.Forms.Button();
            this.buttonManagementWin32_Processor = new System.Windows.Forms.Button();
            this.buttonManagementBIOS = new System.Windows.Forms.Button();
            this.buttonManagementAutomation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonListProcesses
            // 
            this.buttonListProcesses.Location = new System.Drawing.Point(12, 12);
            this.buttonListProcesses.Name = "buttonListProcesses";
            this.buttonListProcesses.Size = new System.Drawing.Size(130, 30);
            this.buttonListProcesses.TabIndex = 0;
            this.buttonListProcesses.Text = "Список процессов";
            this.buttonListProcesses.UseVisualStyleBackColor = true;
            this.buttonListProcesses.Click += new System.EventHandler(this.buttonListProcesses_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(148, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(130, 30);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Запустить процесс";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonEnvironment
            // 
            this.buttonEnvironment.Location = new System.Drawing.Point(12, 83);
            this.buttonEnvironment.Name = "buttonEnvironment";
            this.buttonEnvironment.Size = new System.Drawing.Size(130, 30);
            this.buttonEnvironment.TabIndex = 4;
            this.buttonEnvironment.Text = "Environment";
            this.buttonEnvironment.UseVisualStyleBackColor = true;
            this.buttonEnvironment.Click += new System.EventHandler(this.buttonEnvironment_Click);
            // 
            // buttonManagementWin32_Processor
            // 
            this.buttonManagementWin32_Processor.Location = new System.Drawing.Point(148, 83);
            this.buttonManagementWin32_Processor.Name = "buttonManagementWin32_Processor";
            this.buttonManagementWin32_Processor.Size = new System.Drawing.Size(190, 30);
            this.buttonManagementWin32_Processor.TabIndex = 5;
            this.buttonManagementWin32_Processor.Text = "Management Win32_Processor";
            this.buttonManagementWin32_Processor.UseVisualStyleBackColor = true;
            this.buttonManagementWin32_Processor.Click += new System.EventHandler(this.buttonManagementWin32_Processor_Click);
            // 
            // buttonManagementBIOS
            // 
            this.buttonManagementBIOS.Location = new System.Drawing.Point(12, 119);
            this.buttonManagementBIOS.Name = "buttonManagementBIOS";
            this.buttonManagementBIOS.Size = new System.Drawing.Size(130, 30);
            this.buttonManagementBIOS.TabIndex = 6;
            this.buttonManagementBIOS.Text = "Management BIOS";
            this.buttonManagementBIOS.UseVisualStyleBackColor = true;
            this.buttonManagementBIOS.Click += new System.EventHandler(this.buttonManagementBIOS_Click);
            // 
            // buttonManagementAutomation
            // 
            this.buttonManagementAutomation.Location = new System.Drawing.Point(148, 119);
            this.buttonManagementAutomation.Name = "buttonManagementAutomation";
            this.buttonManagementAutomation.Size = new System.Drawing.Size(190, 30);
            this.buttonManagementAutomation.TabIndex = 7;
            this.buttonManagementAutomation.Text = "Management Automation";
            this.buttonManagementAutomation.UseVisualStyleBackColor = true;
            this.buttonManagementAutomation.Click += new System.EventHandler(this.buttonManagementAutomation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "System Info";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonManagementAutomation);
            this.Controls.Add(this.buttonManagementBIOS);
            this.Controls.Add(this.buttonManagementWin32_Processor);
            this.Controls.Add(this.buttonEnvironment);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonListProcesses);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Приложение для работы с процессами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonListProcesses;
        private Button buttonRun;
        private Button buttonEnvironment;
        private Button buttonManagementWin32_Processor;
        private Button buttonManagementBIOS;
        private Button buttonManagementAutomation;
        private Label label1;
    }
}