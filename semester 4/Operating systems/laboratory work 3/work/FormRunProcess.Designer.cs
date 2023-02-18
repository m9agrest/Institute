namespace work
{
    partial class FormRunProcess
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
            this.buttonFile = new System.Windows.Forms.Button();
            this.listBoxArguments = new System.Windows.Forms.ListBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxArgument = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(12, 12);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(130, 30);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "Выбрать файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // listBoxArguments
            // 
            this.listBoxArguments.FormattingEnabled = true;
            this.listBoxArguments.ItemHeight = 15;
            this.listBoxArguments.Location = new System.Drawing.Point(148, 12);
            this.listBoxArguments.Name = "listBoxArguments";
            this.listBoxArguments.Size = new System.Drawing.Size(333, 199);
            this.listBoxArguments.TabIndex = 1;
            this.listBoxArguments.SelectedIndexChanged += new System.EventHandler(this.listBoxArguments_SelectedIndexChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(12, 178);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(130, 30);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Запустить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 90);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить аргумент";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxArgument
            // 
            this.textBoxArgument.Location = new System.Drawing.Point(12, 61);
            this.textBoxArgument.Name = "textBoxArgument";
            this.textBoxArgument.Size = new System.Drawing.Size(130, 23);
            this.textBoxArgument.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(12, 126);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(130, 30);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Удалить выб. аргум.";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // FormRunProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 220);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxArgument);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.listBoxArguments);
            this.Controls.Add(this.buttonFile);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRunProcess";
            this.Text = "Запуск нового процесса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonFile;
        private ListBox listBoxArguments;
        private Button buttonRun;
        private Button buttonAdd;
        private TextBox textBoxArgument;
        private Button buttonRemove;
    }
}