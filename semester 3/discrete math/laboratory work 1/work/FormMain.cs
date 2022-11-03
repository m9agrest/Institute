using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string[] A { get => textBoxA.Text.Split(' '); }
        string[] B { get => textBoxB.Text.Split(' '); }
        private void RemoveA(object sender, EventArgs e) => Result(Operation.Remove(A));
        private void RemoveB(object sender, EventArgs e) => Result(Operation.Remove(B));
        private void UnionAB(object sender, EventArgs e) => Result(Operation.Union(A, B));
        private void IntersectionAB(object sender, EventArgs e) => Result(Operation.Intersection(A, B));
        private void DifferenceAB(object sender, EventArgs e) => Result(Operation.Difference(A, B));
        private void DifferenceBA(object sender, EventArgs e) => Result(Operation.Difference(B, A));
        private void Result(string[] a)
        {
            string A = "";
            for (int i = 0; i < a.Length; i++)
            {
                A += a[i];
                if (i < a.Length - 1)
                    A += " ";
            }
            textBoxResult.Text = A;
        }
    }
}
