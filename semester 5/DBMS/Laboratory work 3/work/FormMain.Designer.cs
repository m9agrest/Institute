namespace work
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
            this.Data = new System.Windows.Forms.DataGridView();
            this.List = new System.Windows.Forms.ListBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.BackgroundColor = System.Drawing.Color.White;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(262, 12);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 25;
            this.Data.Size = new System.Drawing.Size(416, 423);
            this.Data.TabIndex = 0;
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.White;
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 15;
            this.List.Location = new System.Drawing.Point(93, 12);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(163, 394);
            this.List.TabIndex = 1;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(12, 12);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(12, 41);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(75, 23);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Location = new System.Drawing.Point(93, 412);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(163, 23);
            this.buttonUpdateList.TabIndex = 4;
            this.buttonUpdateList.Text = "Update List";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 131);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 160);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 447);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdateList);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Data);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 486);
            this.MinimumSize = new System.Drawing.Size(706, 486);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Data;
        private ListBox List;
        private Button buttonAdmin;
        private Button buttonUser;
        private Button buttonUpdateList;
        private Button buttonAdd;
        private Button buttonEdit;
    }
}