using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace lab9
{
    public partial class FormMain : Form
    {
        private Machinegun machinegun;
        public FormMain()
        {
            InitializeComponent();
            machinegun = new Machinegun();
            machinegun.UpdateState += UpdateEvent;
            UpdateEvent();
            InitializeTimer();
        }

        private void ButtonPullTrigger_Click(object sender, EventArgs e) => machinegun.PullTrigger();
        private void ButtonReleaseTrigger_Click(object sender, EventArgs e) => machinegun.ReleaseTrigger();
        private void ButtonRecharge_Click(object sender, EventArgs e) => machinegun.Recharge();

        private void ButtonFix_Click(object sender, EventArgs e) 
            => LabelLog.Text = $"Log: {machinegun.State.Fix()}";
        private void ButtonShoot_Click(object sender, EventArgs e) 
            => LabelLog.Text = $"Log: {machinegun.State.Shoot()}";
        private void ButtonStopShoot_Click(object sender, EventArgs e) 
            => LabelLog.Text = $"Log: {machinegun.State.StopShoot()}";

        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = (int)((double)(1000 * machinegun.RateOfFire));
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Enabled = true;
            timer.Start();
        }
        private void UpdateEvent() => LabelState.Text = $"State: {machinegun.State.Name}";
        private void Timer_Tick(object Sender, EventArgs e)
        {
            machinegun.Shooting();
            LabelAmmo.Text = $"Ammo: {machinegun.CountOfRoundsInStore}/{machinegun.MaxCountOfRoundsInStore}";
        }
    }
}
