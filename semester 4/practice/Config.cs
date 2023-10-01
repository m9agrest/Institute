using Newtonsoft.Json.Linq;

public static class Config
{
    private static string Path;
    private static JObject json;
    private static JObject jsonFiles => (JObject)json["Files"];

    public static int Type = 0;
    public static string Service = "afarys";
    public static ushort Port = 10101;
    public static string Name = "None";
    public static Dictionary<string, string> Files = new Dictionary<string, string>();


    public static void Load(string Path)
    {
        Config.Path = Path;
        if (File.Exists(Path)) //проверка, есть ли файл с конфигом
            ReadConfig(); // чтение конфигов из файла
        else
            CreateConfig(); // создание файла с конфигами
    }
    private static void CreateConfig()
    {
        FileStream fileStream = File.Create(Path); 
        fileStream.Close();
        json = new JObject
        {
            { "Service", Service },
            { "Name", Name },
            { "Type", Type },
            { "Files", new JObject() }
        };
        save();
    }
    private static void ReadConfig()
    {
        json = JObject.Parse(File.ReadAllText(Path));
        bool full = true; //полный ли файл
        #region Type
        if (!json.ContainsKey("Type"))
        {
            full = false;
            json.Add("Type", Type);
        }
        Type = (int)json["Type"];
        #endregion
        #region Service
        if (!json.ContainsKey("Service"))
        {
            full = false;
            json.Add("Service", Service);
        }
        Service = (string)json["Service"];
        #endregion
        #region Port
        if (!json.ContainsKey("Port"))
        {
            full = false;
            json.Add("Port", Port);
        }
        Port = (ushort)json["Port"];
        #endregion
        #region Name
        if (!json.ContainsKey("Name"))
        {
            full = false;
            json.Add("Name", Name);
        }
        Name = (string)json["Name"];
        #endregion
        #region Files
        if (!json.ContainsKey("Files"))
        {
            full = false;
            json.Add("Files", new JObject());
        }
        Files = ((JObject)json["Files"]).ToObject<Dictionary<string, string>>();
        #endregion
        if (!full)
        {
            save();
        }
    }
    private static void save()
    {
        StreamWriter streamWriter = new StreamWriter(Path);
        streamWriter.Write(json);
        streamWriter.Close();
    }
    public static void FilesAdd(string key, string Path)
    {
        if (!jsonFiles.ContainsKey(key))
        {
            jsonFiles.Add(key, Path);
            save();
        }
        else
            FilesUpdate(key, Path);
    }
    public static void FilesUpdate(string key, string Path)
    {
        if (jsonFiles.ContainsKey(key))
        {
            jsonFiles[key] = Path;
            save();
        }
        else
            FilesAdd(key, Path);
    }
    public static void FilesRemote(string key)
    {
        if (jsonFiles.ContainsKey(key))
        {
            jsonFiles.Remove(key);
            save();
        }
    }
    public static void NameUpdate(string Name)
    {
        if (Name != null)
        {
            json["Name"] = Name;
            Config.Name = Name;
            save();
        }
    }
    public static void Update(JObject json)
    {
        if(json != null)
        {
            if(json.ContainsKey("Service"))
            {
                Service = (string)json["Service"];
                Config.json["Service"] = json["Service"];
            }
            if(json.ContainsKey("Name"))
            {
                Name = (string)json["Name"];
                Config.json["Name"] = json["Name"];
            }
            if (json.ContainsKey("Type"))
            {
                Type = (int)json["Type"];
                Config.json["Type"] = json["Type"];
            }
            if (json.ContainsKey("Files"))
            {
                Files = ((JObject)json["Files"]).ToObject<Dictionary<string, string>>();
                Config.json["Files"] = json["Files"];
            }
            save();
        }
    }
}
