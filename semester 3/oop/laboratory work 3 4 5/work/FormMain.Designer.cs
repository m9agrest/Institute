
namespace lab345
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FormMenu = new System.Windows.Forms.MenuStrip();
            this.FormMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FormMenuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewBuyer = new System.Windows.Forms.DataGridView();
            this.DataGridViewBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewBuyerLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewBuyerPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewBuyerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBuyer)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMenu
            // 
            this.FormMenu.BackColor = System.Drawing.Color.White;
            this.FormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormMenuFile});
            this.FormMenu.Location = new System.Drawing.Point(0, 0);
            this.FormMenu.Name = "FormMenu";
            this.FormMenu.Size = new System.Drawing.Size(800, 24);
            this.FormMenu.TabIndex = 1;
            this.FormMenu.Text = "FormMenu";
            // 
            // FormMenuFile
            // 
            this.FormMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormMenuFileNew,
            this.FormMenuFileOpen,
            this.FormMenuFileSave,
            this.FormMenuFileSaveAs});
            this.FormMenuFile.Name = "FormMenuFile";
            this.FormMenuFile.Size = new System.Drawing.Size(48, 20);
            this.FormMenuFile.Text = "Файл";
            // 
            // FormMenuFileNew
            // 
            this.FormMenuFileNew.Name = "FormMenuFileNew";
            this.FormMenuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FormMenuFileNew.Size = new System.Drawing.Size(217, 22);
            this.FormMenuFileNew.Text = "Новый";
            this.FormMenuFileNew.Click += new System.EventHandler(this.FormMenuFileNew_Click);
            // 
            // FormMenuFileOpen
            // 
            this.FormMenuFileOpen.Name = "FormMenuFileOpen";
            this.FormMenuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FormMenuFileOpen.Size = new System.Drawing.Size(217, 22);
            this.FormMenuFileOpen.Text = "Открыть";
            this.FormMenuFileOpen.Click += new System.EventHandler(this.FormMenuFileOpen_Click);
            // 
            // FormMenuFileSave
            // 
            this.FormMenuFileSave.Name = "FormMenuFileSave";
            this.FormMenuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FormMenuFileSave.Size = new System.Drawing.Size(217, 22);
            this.FormMenuFileSave.Text = "Сохранить";
            this.FormMenuFileSave.Click += new System.EventHandler(this.FormMenuFileSave_Click);
            // 
            // FormMenuFileSaveAs
            // 
            this.FormMenuFileSaveAs.Name = "FormMenuFileSaveAs";
            this.FormMenuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.FormMenuFileSaveAs.Size = new System.Drawing.Size(217, 22);
            this.FormMenuFileSaveAs.Text = "Сохранить как";
            this.FormMenuFileSaveAs.Click += new System.EventHandler(this.FormMenuFileSaveAs_Click);
            // 
            // DataGridViewBuyer
            // 
            this.DataGridViewBuyer.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewBuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBuyer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewBuyerName,
            this.DataGridViewBuyerLastname,
            this.DataGridViewBuyerPatronymic,
            this.DataGridViewBuyerAddress});
            this.DataGridViewBuyer.GridColor = System.Drawing.Color.Black;
            this.DataGridViewBuyer.Location = new System.Drawing.Point(0, 27);
            this.DataGridViewBuyer.Name = "DataGridViewBuyer";
            this.DataGridViewBuyer.RowTemplate.Height = 25;
            this.DataGridViewBuyer.Size = new System.Drawing.Size(800, 427);
            this.DataGridViewBuyer.TabIndex = 2;
            // 
            // DataGridViewBuyerName
            // 
            this.DataGridViewBuyerName.HeaderText = "Имя";
            this.DataGridViewBuyerName.Name = "DataGridViewBuyerName";
            // 
            // DataGridViewBuyerLastname
            // 
            this.DataGridViewBuyerLastname.HeaderText = "Фамилия";
            this.DataGridViewBuyerLastname.Name = "DataGridViewBuyerLastname";
            // 
            // DataGridViewBuyerPatronymic
            // 
            this.DataGridViewBuyerPatronymic.HeaderText = "Отчество";
            this.DataGridViewBuyerPatronymic.Name = "DataGridViewBuyerPatronymic";
            // 
            // DataGridViewBuyerAddress
            // 
            this.DataGridViewBuyerAddress.HeaderText = "Адрес";
            this.DataGridViewBuyerAddress.Name = "DataGridViewBuyerAddress";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewBuyer);
            this.Controls.Add(this.FormMenu);
            this.MainMenuStrip = this.FormMenu;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormMenu.ResumeLayout(false);
            this.FormMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBuyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip FormMenu;
        private System.Windows.Forms.ToolStripMenuItem FormMenuFile;
        private System.Windows.Forms.ToolStripMenuItem FormMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem FormMenuFileSave;
        private System.Windows.Forms.ToolStripMenuItem FormMenuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem FormMenuFileNew;
        private System.Windows.Forms.DataGridView DataGridViewBuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewBuyerLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewBuyerPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewBuyerAddress;
    }
}