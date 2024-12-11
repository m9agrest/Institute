using Microsoft.VisualBasic.ApplicationServices;

namespace lab4
{
    public partial class FormRights : Form
    {
        public FormRights()
        {
            InitializeComponent();

            foreach (ActionType action in Enum.GetValues(typeof(ActionType)))
            {
                ActionTypes.Items.Add(action);
            }

            foreach (UserType user in Enum.GetValues(typeof(UserType)))
            {
                Button btn = new Button();
                btn.Width = UserTypes.Width - 10;
                btn.Text = user.ToString();
                EventHandler clickHandler = (o, a) =>
                {
                    Selected = user;
                    Text = "Rights: " + Selected.ToString();
                    for (int i = 0; i < ActionTypes.Items.Count; i++)
                    {
                        ActionType action = (ActionType)ActionTypes.Items[i];
                        if (Program.Rights[user].Contains(action))
                        {
                            ActionTypes.SetItemChecked(i, true);
                        }
                        else
                        {
                            ActionTypes.SetItemChecked(i, false);
                        }
                    }
                };
                btn.Click += clickHandler;
                UserTypes.Controls.Add(btn);
                if (user == UserType.DEFAULT)
                {
                    btn.Select();
                    clickHandler(btn, EventArgs.Empty);
                }
            }
        }
        UserType Selected = UserType.DEFAULT;
        private void button1_Click(object sender, EventArgs e)
        {
            List<ActionType> list = new List<ActionType>();
            foreach (ActionType item in ActionTypes.CheckedItems)
            {
                list.Add(item);
            }
            Program.Rights.Remove(Selected);
            Program.Rights.Add(Selected, list);

        }
    }
}
