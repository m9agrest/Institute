namespace OS5
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxv = new System.Windows.Forms.TextBox();
            this.textBoxd = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonProc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxSort = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxGen = new System.Windows.Forms.RichTextBox();
            this.richTextBoxProc = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во генерируемых задач (N)";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(15, 28);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(209, 22);
            this.textBoxN.TabIndex = 1;
            this.textBoxN.Text = "39";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Центральный процессор (k+-l)";
            // 
            // textBoxk
            // 
            this.textBoxk.Location = new System.Drawing.Point(15, 72);
            this.textBoxk.Name = "textBoxk";
            this.textBoxk.Size = new System.Drawing.Size(92, 22);
            this.textBoxk.TabIndex = 3;
            this.textBoxk.Text = "265";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "+-";
            // 
            // textBoxl
            // 
            this.textBoxl.Location = new System.Drawing.Point(137, 72);
            this.textBoxl.Name = "textBoxl";
            this.textBoxl.Size = new System.Drawing.Size(87, 22);
            this.textBoxl.TabIndex = 6;
            this.textBoxl.Text = "96";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Жёсткий диск (m+-v)";
            // 
            // textBoxm
            // 
            this.textBoxm.Location = new System.Drawing.Point(15, 116);
            this.textBoxm.Name = "textBoxm";
            this.textBoxm.Size = new System.Drawing.Size(92, 22);
            this.textBoxm.TabIndex = 8;
            this.textBoxm.Text = "233";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сеть (b+-d)";
            // 
            // textBoxb
            // 
            this.textBoxb.Location = new System.Drawing.Point(15, 160);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(92, 22);
            this.textBoxb.TabIndex = 11;
            this.textBoxb.Text = "462";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "+-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "+-";
            // 
            // textBoxv
            // 
            this.textBoxv.Location = new System.Drawing.Point(137, 116);
            this.textBoxv.Name = "textBoxv";
            this.textBoxv.Size = new System.Drawing.Size(87, 22);
            this.textBoxv.TabIndex = 15;
            this.textBoxv.Text = "51";
            // 
            // textBoxd
            // 
            this.textBoxd.Location = new System.Drawing.Point(137, 160);
            this.textBoxd.Name = "textBoxd";
            this.textBoxd.Size = new System.Drawing.Size(87, 22);
            this.textBoxd.TabIndex = 16;
            this.textBoxd.Text = "95";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(15, 188);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(209, 26);
            this.buttonGen.TabIndex = 17;
            this.buttonGen.Text = "Сгенерировать список задач";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(15, 220);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(209, 26);
            this.buttonSort.TabIndex = 18;
            this.buttonSort.Text = "Отсортеровать список задач";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonProc
            // 
            this.buttonProc.Location = new System.Drawing.Point(15, 252);
            this.buttonProc.Name = "buttonProc";
            this.buttonProc.Size = new System.Drawing.Size(209, 26);
            this.buttonProc.TabIndex = 19;
            this.buttonProc.Text = "Смоделировать выполнение";
            this.buttonProc.UseVisualStyleBackColor = true;
            this.buttonProc.Click += new System.EventHandler(this.buttonProc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Сгенерированные задачи";
            // 
            // richTextBoxSort
            // 
            this.richTextBoxSort.Location = new System.Drawing.Point(422, 28);
            this.richTextBoxSort.Name = "richTextBoxSort";
            this.richTextBoxSort.Size = new System.Drawing.Size(186, 250);
            this.richTextBoxSort.TabIndex = 23;
            this.richTextBoxSort.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Отсортерованные задачи";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Процесс выполнения задач";
            // 
            // richTextBoxGen
            // 
            this.richTextBoxGen.Location = new System.Drawing.Point(230, 28);
            this.richTextBoxGen.Name = "richTextBoxGen";
            this.richTextBoxGen.Size = new System.Drawing.Size(186, 250);
            this.richTextBoxGen.TabIndex = 26;
            this.richTextBoxGen.Text = "";
            // 
            // richTextBoxProc
            // 
            this.richTextBoxProc.Location = new System.Drawing.Point(614, 27);
            this.richTextBoxProc.Name = "richTextBoxProc";
            this.richTextBoxProc.Size = new System.Drawing.Size(186, 250);
            this.richTextBoxProc.TabIndex = 27;
            this.richTextBoxProc.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 289);
            this.Controls.Add(this.richTextBoxProc);
            this.Controls.Add(this.richTextBoxGen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBoxSort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonProc);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxd);
            this.Controls.Add(this.textBoxv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxv;
        private System.Windows.Forms.TextBox textBoxd;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonProc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxSort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxGen;
        private System.Windows.Forms.RichTextBox richTextBoxProc;
        private System.Windows.Forms.Timer timer1;
    }
}

