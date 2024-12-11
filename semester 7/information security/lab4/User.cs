using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class User
    {
        private Dictionary<ActionType, bool> Rights = new Dictionary<ActionType, bool>();
        private UserType userType;
        public string Name = "";

        public User(string name, UserType type)
        {
            Name = name;
            userType = type;
        }

        public bool isRight(ActionType type)
        {
            if (Rights.ContainsKey(type))
            {
                return Rights[type];
            }
            return Program.Rights[userType].Contains(type);
        }
        public void DefaultRight()
        {
            Rights = new Dictionary<ActionType, bool>();
        }
        public void RemoveRights(ActionType type)
        {
            Rights.Remove(type);
        }
        public void SetRight(ActionType type, bool allowed)
        {
            Rights.Remove(type);
            Rights.Add(type, allowed);
        }
    }
}
