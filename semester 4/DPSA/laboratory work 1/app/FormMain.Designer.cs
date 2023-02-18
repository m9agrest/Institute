namespace app
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.radioButtonGnomeSort = new System.Windows.Forms.RadioButton();
            this.radioButtonBubleSort = new System.Windows.Forms.RadioButton();
            this.radioButtonCountingSort = new System.Windows.Forms.RadioButton();
            this.buttonSaveSort = new System.Windows.Forms.Button();
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBoxArray = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxSortArray = new System.Windows.Forms.RichTextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(133, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Выбрать файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(12, 69);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(133, 23);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(12, 98);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(101, 19);
            this.checkBoxTime.TabIndex = 2;
            this.checkBoxTime.Text = "Засечь время";
            this.checkBoxTime.UseMnemonic = false;
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(12, 123);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(166, 19);
            this.checkBoxData.TabIndex = 3;
            this.checkBoxData.Text = "Дополнительные данные";
            this.checkBoxData.UseVisualStyleBackColor = true;
            // 
            // radioButtonGnomeSort
            // 
            this.radioButtonGnomeSort.AutoSize = true;
            this.radioButtonGnomeSort.Checked = true;
            this.radioButtonGnomeSort.Location = new System.Drawing.Point(12, 148);
            this.radioButtonGnomeSort.Name = "radioButtonGnomeSort";
            this.radioButtonGnomeSort.Size = new System.Drawing.Size(133, 19);
            this.radioButtonGnomeSort.TabIndex = 4;
            this.radioButtonGnomeSort.TabStop = true;
            this.radioButtonGnomeSort.Text = "Гномья сортировка";
            // 
            // radioButtonBubleSort
            // 
            this.radioButtonBubleSort.AutoSize = true;
            this.radioButtonBubleSort.Location = new System.Drawing.Point(12, 173);
            this.radioButtonBubleSort.Name = "radioButtonBubleSort";
            this.radioButtonBubleSort.Size = new System.Drawing.Size(156, 19);
            this.radioButtonBubleSort.TabIndex = 5;
            this.radioButtonBubleSort.Text = "Сортировка пузырьком";
            this.radioButtonBubleSort.UseVisualStyleBackColor = true;
            // 
            // radioButtonCountingSort
            // 
            this.radioButtonCountingSort.AutoSize = true;
            this.radioButtonCountingSort.Location = new System.Drawing.Point(12, 198);
            this.radioButtonCountingSort.Name = "radioButtonCountingSort";
            this.radioButtonCountingSort.Size = new System.Drawing.Size(154, 19);
            this.radioButtonCountingSort.TabIndex = 6;
            this.radioButtonCountingSort.Text = "Сортировка подсчетом";
            this.radioButtonCountingSort.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSort
            // 
            this.buttonSaveSort.Location = new System.Drawing.Point(290, 12);
            this.buttonSaveSort.Name = "buttonSaveSort";
            this.buttonSaveSort.Size = new System.Drawing.Size(133, 23);
            this.buttonSaveSort.TabIndex = 7;
            this.buttonSaveSort.Text = "Сохранить сорт.";
            this.buttonSaveSort.UseVisualStyleBackColor = true;
            this.buttonSaveSort.Click += new System.EventHandler(this.buttonSaveSort_Click);
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Location = new System.Drawing.Point(463, 11);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(133, 23);
            this.buttonGeneration.TabIndex = 8;
            this.buttonGeneration.Text = "Сгенерировать";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(151, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить массив.";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBoxArray
            // 
            this.richTextBoxArray.Location = new System.Drawing.Point(184, 87);
            this.richTextBoxArray.Name = "richTextBoxArray";
            this.richTextBoxArray.Size = new System.Drawing.Size(604, 98);
            this.richTextBoxArray.TabIndex = 10;
            this.richTextBoxArray.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Массив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сортированный массив";
            // 
            // richTextBoxSortArray
            // 
            this.richTextBoxSortArray.Location = new System.Drawing.Point(184, 220);
            this.richTextBoxSortArray.Name = "richTextBoxSortArray";
            this.richTextBoxSortArray.Size = new System.Drawing.Size(604, 98);
            this.richTextBoxSortArray.TabIndex = 13;
            this.richTextBoxSortArray.Text = "";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(655, 12);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(133, 23);
            this.textBoxSize.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Размер";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.richTextBoxSortArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxArray);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonGeneration);
            this.Controls.Add(this.buttonSaveSort);
            this.Controls.Add(this.radioButtonCountingSort);
            this.Controls.Add(this.radioButtonBubleSort);
            this.Controls.Add(this.radioButtonGnomeSort);
            this.Controls.Add(this.checkBoxData);
            this.Controls.Add(this.checkBoxTime);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonOpenFile);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOpenFile;
        private Button buttonSort;
        private CheckBox checkBoxTime;
        private CheckBox checkBoxData;
        private RadioButton radioButtonGnomeSort;
        private RadioButton radioButtonBubleSort;
        private RadioButton radioButtonCountingSort;
        private Button buttonSaveSort;
        private Button buttonGeneration;
        private Button buttonSave;
        private RichTextBox richTextBoxArray;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxSortArray;
        private TextBox textBoxSize;
        private Label label3;
    }
}