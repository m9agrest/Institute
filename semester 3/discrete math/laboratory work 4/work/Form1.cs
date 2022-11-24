using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3dis
{
    public partial class Form1 : Form
    {
        private Graph g;
        private int from { get => edges(TextBoxFrom); }
        private int to { get => edges(TextBoxTo); }
        public Form1()
        {
            g = new Graph();
            InitializeComponent();
        }
        private int edges(TextBox textBox)
        {
            int r = 0;
            int.TryParse(textBox.Text, out r);
            if (r < 0)
                r = 0;
            if (r >= g.numEdges)
                r = g.numEdges - 1;
            return r;
        }
        private void ButtonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы json|*.json";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                g = new Graph(OPF.FileName);
            }
        }

        private void ButtonTracerDijkstraAlgm_Click(object sender, EventArgs e) => LabelTracer.Text = $"Путь из {from} в {to}: {g.DijkstraAlgm(from, to)}";

        private void ButtonTracerBFS_Click(object sender, EventArgs e) => LabelTracer.Text = $"Путь из {from} в {to}: {g.BFS(from, to)}";
    }
}
