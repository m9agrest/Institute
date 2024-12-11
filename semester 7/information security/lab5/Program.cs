using System.Management;

class Program
{
    static string thisPath = "C:/Users/mina987/Desktop/Security/KEY";
    static void Main(string[] args)
    {
        string diskVolume = GetDiskVolume();
        string motherboardSerial = GetMotherboardSerial();
        string usbSerial = GetUSBSerial();

        // Создаем уникальный ключ
        string uniqueKey = $"{diskVolume}-{motherboardSerial}-{usbSerial}";
        Console.WriteLine("Ваш уникальный ключ: " + uniqueKey);

        string storedKey;

        if (File.Exists(thisPath))
        {
            storedKey = File.ReadAllText(thisPath);
        }
        else
        {
            storedKey = uniqueKey;
            File.WriteAllText(thisPath, storedKey);
        }

        if (uniqueKey == storedKey)
        {
            Console.WriteLine("Доступ разрешен. Программа запускается.");
        }
        else
        {
            Console.WriteLine("Доступ запрещен. Неверный ключ.");
        }
    }

    // Получение объема жесткого диска
    static string GetDiskVolume()
    {
        try
        {
            DriveInfo drive = new DriveInfo("C"); // Указываем диск
            return drive.TotalSize.ToString(); // Возвращаем объем диска
        }
        catch
        {
            return "Unknown";
        }
    }

    // Получение серийного номера материнской платы
    static string GetMotherboardSerial()
    {
        try
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["SerialNumber"].ToString();
            }
        }
        catch { }
        return "Unknown";
    }

    // Получение серийного номера USB-накопителя
    static string GetUSBSerial()
    {
        try
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_DiskDrive WHERE MediaType = 'Removable Media'");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["SerialNumber"].ToString();
            }
        }
        catch { }
        return "Unknown";
    }
}