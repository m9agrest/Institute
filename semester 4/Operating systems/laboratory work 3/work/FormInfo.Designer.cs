namespace work
{
    partial class FormInfo
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 15;
            this.listBoxData.Location = new System.Drawing.Point(0, 0);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(384, 261);
            this.listBoxData.TabIndex = 0;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.listBoxData);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormInfo";
            this.Text = "FormInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxData;
    }
}