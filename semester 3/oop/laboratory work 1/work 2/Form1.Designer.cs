
namespace lab_1_2
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
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.TitleHeight = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.TitleWidth = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.TitleRadius = new System.Windows.Forms.Label();
            this.checkBoxAngle = new System.Windows.Forms.CheckBox();
            this.TextIsRadius = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonUpSize = new System.Windows.Forms.Button();
            this.LabelTextInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Location = new System.Drawing.Point(93, 24);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHeight.TabIndex = 0;
            // 
            // TitleHeight
            // 
            this.TitleHeight.AutoSize = true;
            this.TitleHeight.Location = new System.Drawing.Point(28, 27);
            this.TitleHeight.Name = "TitleHeight";
            this.TitleHeight.Size = new System.Drawing.Size(45, 13);
            this.TitleHeight.TabIndex = 1;
            this.TitleHeight.Text = "Высота";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(93, 50);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 2;
            // 
            // TitleWidth
            // 
            this.TitleWidth.AutoSize = true;
            this.TitleWidth.Location = new System.Drawing.Point(28, 53);
            this.TitleWidth.Name = "TitleWidth";
            this.TitleWidth.Size = new System.Drawing.Size(46, 13);
            this.TitleWidth.TabIndex = 3;
            this.TitleWidth.Text = "Ширина";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(93, 96);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadius.TabIndex = 4;
            // 
            // TitleRadius
            // 
            this.TitleRadius.AutoSize = true;
            this.TitleRadius.Location = new System.Drawing.Point(28, 99);
            this.TitleRadius.Name = "TitleRadius";
            this.TitleRadius.Size = new System.Drawing.Size(43, 13);
            this.TitleRadius.TabIndex = 5;
            this.TitleRadius.Text = "Радиус";
            // 
            // checkBoxAngle
            // 
            this.checkBoxAngle.AutoSize = true;
            this.checkBoxAngle.Location = new System.Drawing.Point(178, 76);
            this.checkBoxAngle.Name = "checkBoxAngle";
            this.checkBoxAngle.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAngle.TabIndex = 6;
            this.checkBoxAngle.UseVisualStyleBackColor = true;
            // 
            // TextIsRadius
            // 
            this.TextIsRadius.AutoSize = true;
            this.TextIsRadius.Location = new System.Drawing.Point(28, 76);
            this.TextIsRadius.Name = "TextIsRadius";
            this.TextIsRadius.Size = new System.Drawing.Size(111, 13);
            this.TextIsRadius.TabIndex = 7;
            this.TextIsRadius.Text = "Скругление на углах";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(31, 133);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(162, 23);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttomFunctionGenerate);
            // 
            // buttonUpSize
            // 
            this.buttonUpSize.Location = new System.Drawing.Point(31, 162);
            this.buttonUpSize.Name = "buttonUpSize";
            this.buttonUpSize.Size = new System.Drawing.Size(162, 23);
            this.buttonUpSize.TabIndex = 9;
            this.buttonUpSize.Text = "Увеличить в 2 раза";
            this.buttonUpSize.UseVisualStyleBackColor = true;
            this.buttonUpSize.Click += new System.EventHandler(this.buttomFunctionUpsize);
            // 
            // LabelTextInfo
            // 
            this.LabelTextInfo.AutoSize = true;
            this.LabelTextInfo.Location = new System.Drawing.Point(219, 27);
            this.LabelTextInfo.Name = "LabelTextInfo";
            this.LabelTextInfo.Size = new System.Drawing.Size(0, 13);
            this.LabelTextInfo.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 205);
            this.Controls.Add(this.LabelTextInfo);
            this.Controls.Add(this.buttonUpSize);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.TextIsRadius);
            this.Controls.Add(this.checkBoxAngle);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.TextBoxHeight);
            this.Controls.Add(this.TitleRadius);
            this.Controls.Add(this.TitleWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.TitleHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.Label TitleHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label TitleWidth;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label TitleRadius;
        private System.Windows.Forms.CheckBox checkBoxAngle;
        private System.Windows.Forms.Label TextIsRadius;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonUpSize;
        private System.Windows.Forms.Label LabelTextInfo;
    }
}

