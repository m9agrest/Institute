using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class FormSetting : Form
    {



        public FormSetting()
        {
            InitializeComponent();
            inputPort.Controls.RemoveAt(0);
            UpdateInfo();
        }

        private void FormSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
            Hide();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            JObject json = new JObject();
            if(inputName.Text != null && inputName.Text.Trim() != "")
            {
                json.Add("Name", inputName.Text.Trim());
            }

            json.Add("Port", (ushort)inputPort.Value);

            if (inputService.Text != null && inputService.Text.Replace(" ", "") != "")
            {
                json.Add("Service", inputService.Text.Replace(" ", ""));
            }

            json.Add("Type", radioButtonServer.Checked ? 1 : 0);

            JObject jsonFiles = new JObject();
            foreach(DataGridViewRow row in dataGridViewFiles.Rows)
            {
                if (row.Cells[1].Value != null && (string)row.Cells[1].Value != ""
                    && row.Cells[0].Value != null && (string)row.Cells[0].Value != "")
                {
                    jsonFiles.Add((string)row.Cells[0].Value, (string)row.Cells[1].Value);
                }
            }
            json.Add("Files", jsonFiles);
            Config.Update(json);
            DialogResult r = MessageBox.Show(
                "Have you changed some data, do you want to restart the app?", 
                "Restart app?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if(r == DialogResult.Yes)
            {
                Program.Restart();
            }
            Hide();
            UpdateInfo();
        }




        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateInfo();
        }

        private void dataGridViewFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (e.RowIndex < dataGridViewFiles.RowCount - 1 && e.RowIndex >= 0)
                {
                    DataGridViewCell d = dataGridViewFiles[1, e.RowIndex];

                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "application (*.exe)|*.exe";
                    if (d.Value != null && (string)d.Value != "")
                    {
                        dialog.InitialDirectory = Path.GetDirectoryName((string)d.Value);
                    }
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        d.Value = dialog.FileName;
                    }
                }
            }
        }
        private void dataGridViewFiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex < dataGridViewFiles.RowCount - 1 && e.RowIndex >= 0)
                {
                    DataGridViewCell d = dataGridViewFiles[0, e.RowIndex];
                    if (d.Value == null || (string)d.Value == "")
                    {
                        dataGridViewFiles.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        void UpdateInfo()
        {
            radioButtonClient.Checked = true;
            if(Config.Type > 0)
            {
                radioButtonServer.Checked = true;
            }
            inputName.Text = Config.Name;
            inputPort.Value = Config.Port;
            inputService.Text = Config.Service;
            dataGridViewFiles.Rows.Clear();
            foreach (KeyValuePair<string, string> file in Config.Files)
            {
                dataGridViewFiles.Rows.Add(new string[]{file.Key, file.Value });
            }
        }
    }
}
