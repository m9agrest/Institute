using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class TreeNode
    {
        public char info;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(char info)
        {
            this.info = info;
        }

        public TreeNode(char info, TreeNode left, TreeNode right)
        {
            this.info = info;
            this.left = left;
            this.right = right;
        }

        static public void KLP(TreeNode root, RichTextBox box1) //корень левый-правый
        {
            if (root != null)
            {
                box1.Text += $"{root.info}\n";
                if (root.left != null)
                {
                    box1.Text += $"Left node {root.info} - ";
                    KLP(root.left, box1);
                }
                if (root.right != null)
                {
                    box1.Text += $"Right node {root.info} - ";
                    KLP(root.right, box1);
                }
            }

        }
    }
}
