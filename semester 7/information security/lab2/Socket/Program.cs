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

        // ������� ���������� ����
        Form1 form1 = new Form1();
        Form1 form2 = new Form1();

        // ��������� ��� �����
        form1.Show(); // ��������� ������ �����
        form2.Show(); // ��������� ������ �����

        // ��������� ������� ���� ����������
        Application.Run();
    }
}