using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs _e) //TreeNode
        {
            richTextBox1.Clear();

            TreeNode f = new TreeNode('f');
            TreeNode i = new TreeNode('i');
            TreeNode g = new TreeNode('g');
            TreeNode d = new TreeNode('d');
            TreeNode e = new TreeNode('e', f, null);
            TreeNode b = new TreeNode('e', d, e);
            TreeNode h = new TreeNode('e', null, i);
            TreeNode c = new TreeNode('c', g, h);
            TreeNode a = new TreeNode('a', b, c);





            TreeNode.KLP(a, richTextBox1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
