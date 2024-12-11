namespace lab4
{
    internal static class Program
    {

        public static Dictionary<UserType, List<ActionType>> Rights = new Dictionary<UserType, List<ActionType>>();
        public static List<User> Users = new List<User>();

        [STAThread]
        static void Main()
        {
            Rights.Add(UserType.ADMIN, new List<ActionType> {
                ActionType.CREATE_POST,
                ActionType.READ_POST,
                ActionType.UPDATE_POST,
                ActionType.DELETE_POST,
                ActionType.CREATE_USER,
                ActionType.READ_USER,
                ActionType.UPDATE_USER,
                ActionType.DELETE_USER
            });
            Rights.Add(UserType.MODERATOR, new List<ActionType> {
                ActionType.CREATE_POST,
                ActionType.READ_POST,
                ActionType.UPDATE_POST,
                ActionType.DELETE_POST,
                ActionType.READ_USER
            });
            Rights.Add(UserType.EDITOR, new List<ActionType> {
                ActionType.CREATE_POST,
                ActionType.READ_POST,
                ActionType.UPDATE_POST,
                ActionType.DELETE_POST
            });
            Rights.Add(UserType.DEFAULT, new List<ActionType> {
                ActionType.READ_POST
            });


            ApplicationConfiguration.Initialize();
            Application.Run(new FormRights());
        }







    }
}