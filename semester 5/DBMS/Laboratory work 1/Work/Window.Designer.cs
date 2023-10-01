namespace Work
{
    partial class Window
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
            this.buttonTableCreate = new System.Windows.Forms.Button();
            this.buttonTableOpen = new System.Windows.Forms.Button();
            this.buttonColumnCreate = new System.Windows.Forms.Button();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTableCreate
            // 
            this.buttonTableCreate.Location = new System.Drawing.Point(713, 12);
            this.buttonTableCreate.Name = "buttonTableCreate";
            this.buttonTableCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonTableCreate.TabIndex = 0;
            this.buttonTableCreate.Text = "Create";
            this.buttonTableCreate.UseVisualStyleBackColor = true;
            this.buttonTableCreate.Click += new System.EventHandler(this.buttonTableCreate_Click);
            // 
            // buttonTableOpen
            // 
            this.buttonTableOpen.Location = new System.Drawing.Point(713, 41);
            this.buttonTableOpen.Name = "buttonTableOpen";
            this.buttonTableOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonTableOpen.TabIndex = 1;
            this.buttonTableOpen.Text = "Open";
            this.buttonTableOpen.UseVisualStyleBackColor = true;
            this.buttonTableOpen.Click += new System.EventHandler(this.buttonTableOpen_Click);
            // 
            // buttonColumnCreate
            // 
            this.buttonColumnCreate.Location = new System.Drawing.Point(713, 90);
            this.buttonColumnCreate.Name = "buttonColumnCreate";
            this.buttonColumnCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonColumnCreate.TabIndex = 2;
            this.buttonColumnCreate.Text = "Create";
            this.buttonColumnCreate.UseVisualStyleBackColor = true;
            this.buttonColumnCreate.Click += new System.EventHandler(this.buttonColumnCreate_Click);
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(607, 12);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.PlaceholderText = "Table";
            this.textBoxTable.Size = new System.Drawing.Size(100, 23);
            this.textBoxTable.TabIndex = 3;
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(607, 91);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.PlaceholderText = "Column";
            this.textBoxColumn.Size = new System.Drawing.Size(100, 23);
            this.textBoxColumn.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(589, 426);
            this.dataGridView1.TabIndex = 6;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxColumn);
            this.Controls.Add(this.textBoxTable);
            this.Controls.Add(this.buttonColumnCreate);
            this.Controls.Add(this.buttonTableOpen);
            this.Controls.Add(this.buttonTableCreate);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Window";
            this.Text = "Data Base";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonTableCreate;
        private Button buttonTableOpen;
        private Button buttonColumnCreate;
        private TextBox textBoxTable;
        private TextBox textBoxColumn;
        private DataGridView dataGridView1;
    }
}