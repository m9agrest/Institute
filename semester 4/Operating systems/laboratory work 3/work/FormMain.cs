using System.Diagnostics;

namespace work
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Form f = new FormRunProcess();
            f.Show();
        }

        private void buttonListProcesses_Click(object sender, EventArgs e)
        {
            Form f = new FormProcessesInfo();
            f.Show();
        }

        private void buttonEnvironment_Click(object sender, EventArgs e)
        {
            Form f = new FormInfo(FormInfoType.Environment);
            f.Show();
        }
        private void buttonManagementWin32_Processor_Click(object sender, EventArgs e)
        {
            Form f = new FormInfo(FormInfoType.ManagementWin32_Processor);
            f.Show();
        }
        private void buttonManagementBIOS_Click(object sender, EventArgs e)
        {
            Form f = new FormInfo(FormInfoType.ManagementBIOS);
            f.Show();
        }
        private void buttonManagementAutomation_Click(object sender, EventArgs e)
        {
            Form f = new FormInfo(FormInfoType.ManagementAutomation);
            f.Show();
        }
    }
}