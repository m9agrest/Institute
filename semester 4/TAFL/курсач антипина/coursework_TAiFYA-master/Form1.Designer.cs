
namespace coursework_TAiFYA
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.TextMain = new System.Windows.Forms.RichTextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenuButton = new System.Windows.Forms.Panel();
            this.button_complete = new System.Windows.Forms.Button();
            this.button_choiceFile = new System.Windows.Forms.Button();
            this.panelMenuTitle = new System.Windows.Forms.Panel();
            this.panelPlaceOfWork = new System.Windows.Forms.Panel();
            this.button_clearRichBox = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.literalTable = new System.Windows.Forms.DataGridView();
            this.numberL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litaral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.separatorTable = new System.Windows.Forms.DataGridView();
            this.numberR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Separators = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indifTable = new System.Windows.Forms.DataGridView();
            this.numberI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordTable = new System.Windows.Forms.DataGridView();
            this.numberK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tccTable = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.firstTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panelTitle.SuspendLayout();
            this.panelMenuButton.SuspendLayout();
            this.panelPlaceOfWork.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.literalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indifTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextMain
            // 
            this.TextMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextMain.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TextMain.Location = new System.Drawing.Point(1092, 96);
            this.TextMain.Margin = new System.Windows.Forms.Padding(2);
            this.TextMain.Name = "TextMain";
            this.TextMain.Size = new System.Drawing.Size(279, 427);
            this.TextMain.TabIndex = 6;
            this.TextMain.Text = "var a,b : integer;\nc : integer;\nbegin\nrepeat\n c:=c+b;\n b:=1;\nuntil (b>5) or (c>10" +
    "0)\nend.";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1382, 55);
            this.panelTitle.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(491, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(167, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Компилятор";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelMenuButton
            // 
            this.panelMenuButton.BackColor = System.Drawing.Color.Silver;
            this.panelMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuButton.Controls.Add(this.button_complete);
            this.panelMenuButton.Controls.Add(this.button_choiceFile);
            this.panelMenuButton.Controls.Add(this.panelMenuTitle);
            this.panelMenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuButton.Location = new System.Drawing.Point(0, 0);
            this.panelMenuButton.Name = "panelMenuButton";
            this.panelMenuButton.Size = new System.Drawing.Size(200, 591);
            this.panelMenuButton.TabIndex = 11;
            this.panelMenuButton.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuButton_Paint);
            // 
            // button_complete
            // 
            this.button_complete.BackColor = System.Drawing.SystemColors.WindowText;
            this.button_complete.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_complete.FlatAppearance.BorderSize = 0;
            this.button_complete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.button_complete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_complete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_complete.ForeColor = System.Drawing.Color.Beige;
            this.button_complete.Location = new System.Drawing.Point(0, 105);
            this.button_complete.Name = "button_complete";
            this.button_complete.Size = new System.Drawing.Size(198, 50);
            this.button_complete.TabIndex = 14;
            this.button_complete.Text = "Запустить ";
            this.button_complete.UseVisualStyleBackColor = false;
            this.button_complete.Click += new System.EventHandler(this.button_complete_Click);
            // 
            // button_choiceFile
            // 
            this.button_choiceFile.BackColor = System.Drawing.SystemColors.MenuText;
            this.button_choiceFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_choiceFile.FlatAppearance.BorderSize = 0;
            this.button_choiceFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.button_choiceFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_choiceFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_choiceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_choiceFile.ForeColor = System.Drawing.Color.White;
            this.button_choiceFile.Location = new System.Drawing.Point(0, 55);
            this.button_choiceFile.Name = "button_choiceFile";
            this.button_choiceFile.Size = new System.Drawing.Size(198, 50);
            this.button_choiceFile.TabIndex = 13;
            this.button_choiceFile.Text = "Выбрать файл";
            this.button_choiceFile.UseVisualStyleBackColor = false;
            this.button_choiceFile.Click += new System.EventHandler(this.button_choiceFile_Click);
            // 
            // panelMenuTitle
            // 
            this.panelMenuTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTitle.Name = "panelMenuTitle";
            this.panelMenuTitle.Size = new System.Drawing.Size(198, 55);
            this.panelMenuTitle.TabIndex = 12;
            // 
            // panelPlaceOfWork
            // 
            this.panelPlaceOfWork.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelPlaceOfWork.Controls.Add(this.button_clearRichBox);
            this.panelPlaceOfWork.Controls.Add(this.panelTitle);
            this.panelPlaceOfWork.Controls.Add(this.TextMain);
            this.panelPlaceOfWork.Controls.Add(this.tabControl1);
            this.panelPlaceOfWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaceOfWork.Location = new System.Drawing.Point(200, 0);
            this.panelPlaceOfWork.Name = "panelPlaceOfWork";
            this.panelPlaceOfWork.Size = new System.Drawing.Size(1382, 591);
            this.panelPlaceOfWork.TabIndex = 12;
            // 
            // button_clearRichBox
            // 
            this.button_clearRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearRichBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.button_clearRichBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.button_clearRichBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_clearRichBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearRichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clearRichBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_clearRichBox.Location = new System.Drawing.Point(1093, 528);
            this.button_clearRichBox.Name = "button_clearRichBox";
            this.button_clearRichBox.Size = new System.Drawing.Size(277, 50);
            this.button_clearRichBox.TabIndex = 15;
            this.button_clearRichBox.Text = "Очистить ";
            this.button_clearRichBox.UseVisualStyleBackColor = false;
            this.button_clearRichBox.Click += new System.EventHandler(this.button_clearRichBox_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1075, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ТСС таблица";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tccTable);
            this.panel2.Controls.Add(this.keywordTable);
            this.panel2.Controls.Add(this.indifTable);
            this.panel2.Controls.Add(this.separatorTable);
            this.panel2.Controls.Add(this.literalTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 472);
            this.panel2.TabIndex = 7;
            // 
            // literalTable
            // 
            this.literalTable.AllowUserToAddRows = false;
            this.literalTable.AllowUserToDeleteRows = false;
            this.literalTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.literalTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.literalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.literalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Litaral,
            this.numberL});
            this.literalTable.Location = new System.Drawing.Point(680, 0);
            this.literalTable.Margin = new System.Windows.Forms.Padding(2);
            this.literalTable.Name = "literalTable";
            this.literalTable.ReadOnly = true;
            this.literalTable.RowHeadersVisible = false;
            this.literalTable.RowHeadersWidth = 51;
            this.literalTable.RowTemplate.Height = 24;
            this.literalTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.literalTable.Size = new System.Drawing.Size(190, 472);
            this.literalTable.TabIndex = 6;
            this.literalTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.literalTable_CellContentClick);
            // 
            // numberL
            // 
            this.numberL.FillWeight = 81.21828F;
            this.numberL.HeaderText = "Номер";
            this.numberL.Name = "numberL";
            this.numberL.ReadOnly = true;
            // 
            // Litaral
            // 
            this.Litaral.FillWeight = 118.7817F;
            this.Litaral.HeaderText = "Литералы";
            this.Litaral.Name = "Litaral";
            this.Litaral.ReadOnly = true;
            // 
            // separatorTable
            // 
            this.separatorTable.AllowUserToAddRows = false;
            this.separatorTable.AllowUserToDeleteRows = false;
            this.separatorTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.separatorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.separatorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Separators,
            this.numberR});
            this.separatorTable.Location = new System.Drawing.Point(874, 0);
            this.separatorTable.Margin = new System.Windows.Forms.Padding(2);
            this.separatorTable.Name = "separatorTable";
            this.separatorTable.ReadOnly = true;
            this.separatorTable.RowHeadersVisible = false;
            this.separatorTable.RowHeadersWidth = 51;
            this.separatorTable.RowTemplate.Height = 24;
            this.separatorTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.separatorTable.Size = new System.Drawing.Size(195, 472);
            this.separatorTable.TabIndex = 7;
            // 
            // numberR
            // 
            this.numberR.FillWeight = 81.21828F;
            this.numberR.HeaderText = "Номер";
            this.numberR.Name = "numberR";
            this.numberR.ReadOnly = true;
            // 
            // Separators
            // 
            this.Separators.FillWeight = 118.7817F;
            this.Separators.HeaderText = "Разделители ";
            this.Separators.Name = "Separators";
            this.Separators.ReadOnly = true;
            // 
            // indifTable
            // 
            this.indifTable.AllowUserToAddRows = false;
            this.indifTable.AllowUserToDeleteRows = false;
            this.indifTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indifTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.indifTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indifTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifier,
            this.numberI});
            this.indifTable.Location = new System.Drawing.Point(486, 0);
            this.indifTable.Margin = new System.Windows.Forms.Padding(2);
            this.indifTable.Name = "indifTable";
            this.indifTable.ReadOnly = true;
            this.indifTable.RowHeadersVisible = false;
            this.indifTable.RowHeadersWidth = 51;
            this.indifTable.RowTemplate.Height = 24;
            this.indifTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.indifTable.Size = new System.Drawing.Size(190, 472);
            this.indifTable.TabIndex = 5;
            // 
            // numberI
            // 
            this.numberI.FillWeight = 81.21828F;
            this.numberI.HeaderText = "Номер";
            this.numberI.Name = "numberI";
            this.numberI.ReadOnly = true;
            // 
            // Identifier
            // 
            this.Identifier.FillWeight = 118.7817F;
            this.Identifier.HeaderText = "Индификатор";
            this.Identifier.Name = "Identifier";
            this.Identifier.ReadOnly = true;
            // 
            // keywordTable
            // 
            this.keywordTable.AllowUserToAddRows = false;
            this.keywordTable.AllowUserToDeleteRows = false;
            this.keywordTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keywordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keywordTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keywords,
            this.numberK});
            this.keywordTable.Location = new System.Drawing.Point(292, 0);
            this.keywordTable.Margin = new System.Windows.Forms.Padding(2);
            this.keywordTable.Name = "keywordTable";
            this.keywordTable.ReadOnly = true;
            this.keywordTable.RowHeadersVisible = false;
            this.keywordTable.RowHeadersWidth = 51;
            this.keywordTable.RowTemplate.Height = 24;
            this.keywordTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.keywordTable.Size = new System.Drawing.Size(190, 472);
            this.keywordTable.TabIndex = 5;
            // 
            // numberK
            // 
            this.numberK.HeaderText = "Номер";
            this.numberK.Name = "numberK";
            this.numberK.ReadOnly = true;
            this.numberK.Width = 80;
            // 
            // keywords
            // 
            this.keywords.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keywords.HeaderText = "Ключевые слова";
            this.keywords.Name = "keywords";
            this.keywords.ReadOnly = true;
            // 
            // tccTable
            // 
            this.tccTable.AllowUserToAddRows = false;
            this.tccTable.AllowUserToDeleteRows = false;
            this.tccTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tccTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tccTable.Location = new System.Drawing.Point(2, 1);
            this.tccTable.Margin = new System.Windows.Forms.Padding(2);
            this.tccTable.Name = "tccTable";
            this.tccTable.ReadOnly = true;
            this.tccTable.RowHeadersVisible = false;
            this.tccTable.RowHeadersWidth = 51;
            this.tccTable.RowTemplate.Height = 24;
            this.tccTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tccTable.Size = new System.Drawing.Size(286, 471);
            this.tccTable.TabIndex = 4;
            this.tccTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tccTable_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.firstTable);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1075, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Лексический анализ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // firstTable
            // 
            this.firstTable.AllowUserToAddRows = false;
            this.firstTable.AllowUserToDeleteRows = false;
            this.firstTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firstTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstTable.Location = new System.Drawing.Point(2, 2);
            this.firstTable.Name = "firstTable";
            this.firstTable.ReadOnly = true;
            this.firstTable.RowHeadersVisible = false;
            this.firstTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.firstTable.Size = new System.Drawing.Size(1069, 472);
            this.firstTable.TabIndex = 0;
            this.firstTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.firstTable_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(5, 67);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 511);
            this.tabControl1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 591);
            this.Controls.Add(this.panelPlaceOfWork);
            this.Controls.Add(this.panelMenuButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1447, 430);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMenuButton.ResumeLayout(false);
            this.panelPlaceOfWork.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.literalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indifTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Panel panelMenuButton;
		private System.Windows.Forms.Button button_complete;
		private System.Windows.Forms.Button button_choiceFile;
		private System.Windows.Forms.Panel panelMenuTitle;
		private System.Windows.Forms.Panel panelPlaceOfWork;
		private System.Windows.Forms.Button button_clearRichBox;
		public System.Windows.Forms.RichTextBox TextMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView firstTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView tccTable;
        public System.Windows.Forms.DataGridView keywordTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywords;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberK;
        private System.Windows.Forms.DataGridView indifTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberI;
        private System.Windows.Forms.DataGridView separatorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Separators;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberR;
        private System.Windows.Forms.DataGridView literalTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litaral;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberL;
    }
}

