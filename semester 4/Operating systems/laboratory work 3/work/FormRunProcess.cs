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

namespace work
{
    public partial class FormRunProcess : Form
    {
        private string fileName = null;
        public FormRunProcess()
        {
            InitializeComponent();
        }
        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Выбор исполняемого файла";
            dialog.Filter = @"Исполняемые файлы|*.exe;*.bat;*.dll;*.sys|" +
                            @"Файлы EXE|*.exe|" +
                            @"Файлы BAT|*.bat|" +
                            @"Файлы DLL|*.dll|" +
                            @"Файлы SYS|*.sys";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
            }
        }
        int selectItem = -1;
        private void listBoxArguments_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectItem = listBoxArguments.SelectedIndex;
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(selectItem != -1)
            {
                listBoxArguments.Items.RemoveAt(selectItem);
                selectItem = -1;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string text = textBoxArgument.Text.Trim();
            if (text != "")
            {
                listBoxArguments.Items.Add(text);
                textBoxArgument.Text = "";
            }
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            if(fileName != null)
            {
                if(MessageBox.Show(
                    $"Вы действительно готовы запустить\n\"{fileName}\"?",
                    "Запуск нового процесса",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes)
                {
                    string arg = "";
                    for (int i = 0; i < listBoxArguments.Items.Count; i++)
                    {
                        arg += listBoxArguments.Items[i];
                        if (i + 1 != listBoxArguments.Items.Count)
                            arg += " ";
                    }
                    Process MyProcess = Process.Start(fileName, arg);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show(
                    "Выберите исполняемый файл!",
                    "Ошибка запуска нового процесса",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
