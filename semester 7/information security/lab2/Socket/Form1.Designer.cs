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
        bServer = new Button();
        bClient = new Button();
        iIP = new TextBox();
        iPort = new NumericUpDown();
        listLog = new ListBox();
        iMSG = new TextBox();
        bSend = new Button();
        ((System.ComponentModel.ISupportInitialize)iPort).BeginInit();
        SuspendLayout();
        // 
        // bServer
        // 
        bServer.Location = new Point(302, 12);
        bServer.Name = "bServer";
        bServer.Size = new Size(75, 23);
        bServer.TabIndex = 0;
        bServer.Text = "Сервер";
        bServer.UseVisualStyleBackColor = true;
        bServer.Click += bServer_Click;
        // 
        // bClient
        // 
        bClient.Location = new Point(383, 12);
        bClient.Name = "bClient";
        bClient.Size = new Size(75, 23);
        bClient.TabIndex = 1;
        bClient.Text = "Клиент";
        bClient.UseVisualStyleBackColor = true;
        bClient.Click += bClient_Click;
        // 
        // iIP
        // 
        iIP.Location = new Point(12, 12);
        iIP.Name = "iIP";
        iIP.Size = new Size(211, 23);
        iIP.TabIndex = 2;
        iIP.Text = "127.0.0.1";
        // 
        // iPort
        // 
        iPort.Location = new Point(229, 12);
        iPort.Maximum = new decimal(new int[] { 65034, 0, 0, 0 });
        iPort.Name = "iPort";
        iPort.Size = new Size(67, 23);
        iPort.TabIndex = 4;
        iPort.Value = new decimal(new int[] { 30303, 0, 0, 0 });
        // 
        // listLog
        // 
        listLog.FormattingEnabled = true;
        listLog.ItemHeight = 15;
        listLog.Location = new Point(12, 41);
        listLog.Name = "listLog";
        listLog.Size = new Size(446, 364);
        listLog.TabIndex = 5;
        // 
        // iMSG
        // 
        iMSG.Location = new Point(12, 411);
        iMSG.Name = "iMSG";
        iMSG.Size = new Size(365, 23);
        iMSG.TabIndex = 6;
        // 
        // bSend
        // 
        bSend.Location = new Point(383, 411);
        bSend.Name = "bSend";
        bSend.Size = new Size(75, 23);
        bSend.TabIndex = 7;
        bSend.Text = "Отправить";
        bSend.UseVisualStyleBackColor = true;
        bSend.Click += bSend_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(470, 442);
        Controls.Add(bSend);
        Controls.Add(iMSG);
        Controls.Add(listLog);
        Controls.Add(iPort);
        Controls.Add(iIP);
        Controls.Add(bClient);
        Controls.Add(bServer);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)iPort).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button bServer;
    private Button bClient;
    private TextBox iIP;
    private NumericUpDown iPort;
    private ListBox listLog;
    private TextBox iMSG;
    private Button bSend;
}
