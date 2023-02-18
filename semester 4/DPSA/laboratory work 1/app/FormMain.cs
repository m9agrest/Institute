using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class FormMain : Form
    {
        int[] array = null;
        int[] arraySort = null;
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "файл .json (*.json)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(dialog.FileName);
                string strjson = r.ReadToEnd();
                JObject json = JObject.Parse(strjson);
                int Length = (int)json["Length"];
                array = new int[Length];
                for(int  i = 0; i < Length; i++)
                    array[i] = (int)json["Array"][i];
                richTextBoxArray.Text = ArrayToText(array);
            }
        }
        private void buttonGeneration_Click(object sender, EventArgs e)
        {
            int l = 0;
            int.TryParse(textBoxSize.Text, out l);
            array = ArrayAlgorithms.Generation(l, -1000000, 1000000);
            richTextBoxArray.Text = ArrayToText(array);
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            long comparisons = 0;
            long permutations = 0;
            if (array != null)
            {
                arraySort = ArrayAlgorithms.Copy(array);
                if (checkBoxTime.Checked)
                    stopwatch.Start();
                if (radioButtonGnomeSort.Checked)
                    if (checkBoxData.Checked)
                        ArrayAlgorithms.GnomeSort(arraySort, ref comparisons, ref permutations);
                    else
                        ArrayAlgorithms.GnomeSort(arraySort);
                else if (radioButtonBubleSort.Checked)
                    if (checkBoxData.Checked)
                        ArrayAlgorithms.BubleSort(arraySort, ref comparisons, ref permutations);
                    else
                        ArrayAlgorithms.BubleSort(arraySort);
                else if (radioButtonCountingSort.Checked)
                    if (checkBoxData.Checked)
                        ArrayAlgorithms.CountingSort(arraySort, ref comparisons, ref permutations);
                    else
                        ArrayAlgorithms.CountingSort(arraySort);
                else
                {

                }
            }
            string r = "";
            if (checkBoxTime.Checked)
            {
                stopwatch.Stop();
                r += $"Время {stopwatch.ElapsedMilliseconds / 1000.0}\n";
            }
            if (checkBoxData.Checked)
                r += $"Сравнений {comparisons}\nПерестановок {permutations}\n";
            richTextBoxSortArray.Text = r + ArrayToText(arraySort);
        }
        private void buttonSaveSort_Click(object sender, EventArgs e) => Save(arraySort);
        private void buttonSave_Click(object sender, EventArgs e) => Save(array);
        private void Save(int[] array)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "файл .json (*.json)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter s = File.CreateText(dialog.FileName))
                {
                    s.Write(ArrayToJson(array));
                }
            }
        }
        private string ArrayToText(int[] array)
        {
            string r = "";
            for(int i = 0; i < array.Length; i++)
                if(i + 1 != array.Length)
                    r += $"{array[i]} ";
                else
                    r += $"{array[i]}";
            return r;
        }
        private string ArrayToJson(int[] array)
        {
            string r = "{\n\t\"Length\":" + array.Length + ",\n\t\"Array\":[";
            for (int i = 0; i < array.Length; i++)
                if (i + 1 != array.Length)
                    r += $"{array[i]},";
                else
                    r += $"{array[i]}";
            r += "]\n}";
            return r;
        }
    }
}
