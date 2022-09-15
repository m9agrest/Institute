using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_2
{
    public partial class Form1 : Form
    {
        Rectangle rectangle;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttomFunctionGenerate(object sender, EventArgs e)
        {
            int width = 0, height = 0;
            int.TryParse(textBoxWidth.Text, out width);
            int.TryParse(TextBoxHeight.Text, out height);
            if (checkBoxAngle.Checked)
            {
                int radius = 0;
                int.TryParse(textBoxRadius.Text, out radius);
                rectangle = new RectangleRounded(width, height, radius);
            }
            else
                rectangle = new Rectangle(width, height);
            UpdateText();
        }
        private void buttomFunctionUpsize(object sender, EventArgs e)
        {
            rectangle.upSize();
            UpdateText();
        }
        private void UpdateText()
        {
            LabelTextInfo.Text = rectangle.ToString();
        }
    }
}
