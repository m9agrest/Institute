namespace work_2
{
    partial class Form1
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
            this.InputIP = new System.Windows.Forms.TextBox();
            this.InputPort = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InputIP
            // 
            this.InputIP.Location = new System.Drawing.Point(12, 12);
            this.InputIP.Name = "InputIP";
            this.InputIP.Size = new System.Drawing.Size(100, 23);
            this.InputIP.TabIndex = 0;
            this.InputIP.Text = "127.0.0.1";
            // 
            // InputPort
            // 
            this.InputPort.Location = new System.Drawing.Point(118, 12);
            this.InputPort.Name = "InputPort";
            this.InputPort.Size = new System.Drawing.Size(100, 23);
            this.InputPort.TabIndex = 1;
            this.InputPort.Text = "30303";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 94);
            this.listBox1.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(224, 141);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "button1";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(224, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "button2";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 142);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(206, 96);
            this.InputText.TabIndex = 6;
            this.InputText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.InputPort);
            this.Controls.Add(this.InputIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputIP;
        private TextBox InputPort;
        private ListBox listBox1;
        private Button buttonSend;
        private Button buttonConnect;
        private RichTextBox InputText;
    }
}