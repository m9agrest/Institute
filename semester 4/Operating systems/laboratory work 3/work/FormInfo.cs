using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Collections.ObjectModel;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using E = System.Environment;
using System.Management.Automation.Runspaces;
using System.Management.Automation;

namespace work
{
    public enum FormInfoType
    {
        Environment,
        ManagementWin32_Processor,
        ManagementBIOS,
        ManagementAutomation
    }
    public partial class FormInfo : Form
    {
        public FormInfo(FormInfoType type)
        {
            InitializeComponent();
            try
            {
                switch (type)
                {
                    case FormInfoType.Environment:
                        Environment();
                        break;
                    case FormInfoType.ManagementWin32_Processor:
                        Management("Win32_Processor");
                        break;
                    case FormInfoType.ManagementBIOS:
                        Management("Win32_BIOS");
                        break;
                    case FormInfoType.ManagementAutomation:
                        ManagementAutomation();
                        break;
                }
            }
            catch { }
        }
        void Environment()
        {
            listBoxData.Items.Add($"User:");
            listBoxData.Items.Add($"  UserName:  {E.UserName}");
            listBoxData.Items.Add($"  UserDomainName:  {E.UserDomainName}");
            listBoxData.Items.Add($"System:");
            listBoxData.Items.Add($"  OSVersion:  {E.OSVersion}");
            listBoxData.Items.Add($"  SystemDirectory:  {E.SystemDirectory}");
            listBoxData.Items.Add($"  ProcessorCount:  {E.ProcessorCount}");
            listBoxData.Items.Add($"Running process:");
            listBoxData.Items.Add($"  Version:  {E.Version}");
            listBoxData.Items.Add($"  CurrentDirectory:  {E.CurrentDirectory}");
            listBoxData.Items.Add($"  ProcessId:  {E.ProcessId}");
            listBoxData.Items.Add($"  ProcessPath:  {E.ProcessPath}");
            listBoxData.Items.Add($"  WorkingSet:  {((int)(E.WorkingSet / (1024 * 102.4)))/10.0} mb");
            listBoxData.Items.Add($"  UserInteractive:  {E.UserInteractive}");
        }
        void Management(string code)
        {
            ManagementClass myManagementClass = new ManagementClass(code);
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myProperties)
                {
                    listBoxData.Items.Add($"{myProperty.Name}:  {obj.Properties[myProperty.Name].Value}");
                }
            }
        }
        void ManagementAutomation()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            listBoxData.Items.Add($"Version:  {runspace.Version}");
            listBoxData.Items.Add($"Name:  {runspace.Name}");
            listBoxData.Items.Add($"Id:  {runspace.Id}");
            listBoxData.Items.Add($"InstanceId:  {runspace.InstanceId}");
            listBoxData.Items.Add($"JobManager:  {runspace.JobManager}");
            listBoxData.Items.Add($"InitialSessionState:  {runspace.InitialSessionState}");
        }
    }
}
