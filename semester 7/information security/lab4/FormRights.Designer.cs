namespace lab4
{
    partial class FormRights
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
            ActionTypes = new CheckedListBox();
            UserTypes = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // ActionTypes
            // 
            ActionTypes.FormattingEnabled = true;
            ActionTypes.Location = new Point(295, 9);
            ActionTypes.Name = "ActionTypes";
            ActionTypes.Size = new Size(403, 346);
            ActionTypes.TabIndex = 0;
            // 
            // UserTypes
            // 
            UserTypes.Location = new Point(12, 9);
            UserTypes.Name = "UserTypes";
            UserTypes.Size = new Size(277, 381);
            UserTypes.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(540, 367);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 2;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 402);
            Controls.Add(button1);
            Controls.Add(UserTypes);
            Controls.Add(ActionTypes);
            Name = "FormRights";
            Text = "FormRights";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox ActionTypes;
        private FlowLayoutPanel UserTypes;
        private Button button1;
    }
}