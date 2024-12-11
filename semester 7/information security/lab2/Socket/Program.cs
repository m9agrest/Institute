internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Создаем экземпляры форм
        Form1 form1 = new Form1();
        Form1 form2 = new Form1();

        // Запускаем обе формы
        form1.Show(); // Открываем первую форму
        form2.Show(); // Открываем вторую форму

        // Запускаем главный цикл приложения
        Application.Run();
    }
}