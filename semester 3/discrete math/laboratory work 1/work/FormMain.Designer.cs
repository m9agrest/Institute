
namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(92, 20);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(542, 20);
            this.textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(92, 46);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(542, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Массив А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Массив В";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(92, 130);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(542, 20);
            this.textBoxResult.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Исключить повторения А";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveA);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Исключить повторения В";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveB);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Объединение А и В";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.UnionAB);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(483, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Пересичение А и В";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.IntersectionAB);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(326, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Разность А от В";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DifferenceAB);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(483, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Разность В от А";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DifferenceBA);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 161);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.MaximumSize = new System.Drawing.Size(660, 200);
            this.MinimumSize = new System.Drawing.Size(660, 200);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

