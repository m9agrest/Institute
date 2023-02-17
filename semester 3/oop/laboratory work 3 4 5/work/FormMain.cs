using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab345
{
    public partial class FormMain : Form
    {
        private BuyerXML buyers;
        private string fileName = null;
        private bool changed = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMenuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы xml (*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                try
                {
                    buyers = new BuyerXML(fileName);
                }
                catch(Exception)
                {
                    
                }
                
                changed = false;
                DataGridViewBuyer.Rows.Clear();
                buyers = new BuyerXML(fileName);
                foreach(Buyer b in buyers.Buyers)
                    DataGridViewBuyer.Rows.Add(new string[]{b.Name, b.Lastname, b.Patronymic});
            }
        }

        private void FormMenuFileSave_Click(object sender, EventArgs e)
        {
            if (fileName != null)
                save();
            else
                FormMenuFileSaveAs_Click(null, null);
        }

        private void FormMenuFileSaveAs_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы xml (*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                save();
            }
        }

        private void save()
        {
            buyers.Save(fileName);
            changed = false;
        }
        private void isSaved(string text)
        {

        }

        private void FormMenuFileNew_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                //сообщение о том, что у нас не сохранено изменение с прошлого файла
            }
            fileName = null;
            changed = true;
            buyers = new BuyerXML();
            DataGridViewBuyer.Rows.Clear();
        }


    }
}
