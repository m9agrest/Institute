namespace lab9
{
    partial class FormMain
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
            this.LabelState = new System.Windows.Forms.Label();
            this.LabelAmmo = new System.Windows.Forms.Label();
            this.LabelLog = new System.Windows.Forms.Label();
            this.ButtonPullTrigger = new System.Windows.Forms.Button();
            this.ButtonReleaseTrigger = new System.Windows.Forms.Button();
            this.ButtonRecharge = new System.Windows.Forms.Button();
            this.ButtonFix = new System.Windows.Forms.Button();
            this.ButtonShoot = new System.Windows.Forms.Button();
            this.ButtonStopShoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelState
            // 
            this.LabelState.AutoSize = true;
            this.LabelState.Location = new System.Drawing.Point(12, 9);
            this.LabelState.Name = "LabelState";
            this.LabelState.Size = new System.Drawing.Size(38, 15);
            this.LabelState.TabIndex = 0;
            this.LabelState.Text = "label1";
            // 
            // LabelAmmo
            // 
            this.LabelAmmo.AutoSize = true;
            this.LabelAmmo.Location = new System.Drawing.Point(12, 36);
            this.LabelAmmo.Name = "LabelAmmo";
            this.LabelAmmo.Size = new System.Drawing.Size(38, 15);
            this.LabelAmmo.TabIndex = 1;
            this.LabelAmmo.Text = "label1";
            // 
            // LabelLog
            // 
            this.LabelLog.AutoSize = true;
            this.LabelLog.Location = new System.Drawing.Point(12, 64);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(38, 15);
            this.LabelLog.TabIndex = 2;
            this.LabelLog.Text = "label1";
            // 
            // ButtonPullTrigger
            // 
            this.ButtonPullTrigger.Location = new System.Drawing.Point(12, 152);
            this.ButtonPullTrigger.Name = "ButtonPullTrigger";
            this.ButtonPullTrigger.Size = new System.Drawing.Size(75, 23);
            this.ButtonPullTrigger.TabIndex = 3;
            this.ButtonPullTrigger.Text = "Нажать";
            this.ButtonPullTrigger.UseVisualStyleBackColor = true;
            this.ButtonPullTrigger.Click += new System.EventHandler(this.ButtonPullTrigger_Click);
            // 
            // ButtonReleaseTrigger
            // 
            this.ButtonReleaseTrigger.Location = new System.Drawing.Point(12, 181);
            this.ButtonReleaseTrigger.Name = "ButtonReleaseTrigger";
            this.ButtonReleaseTrigger.Size = new System.Drawing.Size(75, 23);
            this.ButtonReleaseTrigger.TabIndex = 4;
            this.ButtonReleaseTrigger.Text = "Отпустить";
            this.ButtonReleaseTrigger.UseVisualStyleBackColor = true;
            this.ButtonReleaseTrigger.Click += new System.EventHandler(this.ButtonReleaseTrigger_Click);
            // 
            // ButtonRecharge
            // 
            this.ButtonRecharge.Location = new System.Drawing.Point(12, 210);
            this.ButtonRecharge.Name = "ButtonRecharge";
            this.ButtonRecharge.Size = new System.Drawing.Size(75, 23);
            this.ButtonRecharge.TabIndex = 5;
            this.ButtonRecharge.Text = "Перезарядить";
            this.ButtonRecharge.UseVisualStyleBackColor = true;
            this.ButtonRecharge.Click += new System.EventHandler(this.ButtonRecharge_Click);
            // 
            // ButtonFix
            // 
            this.ButtonFix.Location = new System.Drawing.Point(93, 152);
            this.ButtonFix.Name = "ButtonFix";
            this.ButtonFix.Size = new System.Drawing.Size(80, 23);
            this.ButtonFix.TabIndex = 6;
            this.ButtonFix.Text = "Чинить";
            this.ButtonFix.UseVisualStyleBackColor = true;
            this.ButtonFix.Click += new System.EventHandler(this.ButtonFix_Click);
            // 
            // ButtonShoot
            // 
            this.ButtonShoot.Location = new System.Drawing.Point(93, 181);
            this.ButtonShoot.Name = "ButtonShoot";
            this.ButtonShoot.Size = new System.Drawing.Size(80, 23);
            this.ButtonShoot.TabIndex = 7;
            this.ButtonShoot.Text = "Стрелять";
            this.ButtonShoot.UseVisualStyleBackColor = true;
            this.ButtonShoot.Click += new System.EventHandler(this.ButtonShoot_Click);
            // 
            // ButtonStopShoot
            // 
            this.ButtonStopShoot.Location = new System.Drawing.Point(93, 210);
            this.ButtonStopShoot.Name = "ButtonStopShoot";
            this.ButtonStopShoot.Size = new System.Drawing.Size(80, 23);
            this.ButtonStopShoot.TabIndex = 8;
            this.ButtonStopShoot.Text = "Не стрелять";
            this.ButtonStopShoot.UseVisualStyleBackColor = true;
            this.ButtonStopShoot.Click += new System.EventHandler(this.ButtonStopShoot_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonStopShoot);
            this.Controls.Add(this.ButtonShoot);
            this.Controls.Add(this.ButtonFix);
            this.Controls.Add(this.ButtonRecharge);
            this.Controls.Add(this.ButtonReleaseTrigger);
            this.Controls.Add(this.ButtonPullTrigger);
            this.Controls.Add(this.LabelLog);
            this.Controls.Add(this.LabelAmmo);
            this.Controls.Add(this.LabelState);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelState;
        private Label LabelAmmo;
        private Label LabelLog;
        private Button ButtonPullTrigger;
        private Button ButtonReleaseTrigger;
        private Button ButtonRecharge;
        private Button ButtonFix;
        private Button ButtonShoot;
        private Button ButtonStopShoot;
    }
}