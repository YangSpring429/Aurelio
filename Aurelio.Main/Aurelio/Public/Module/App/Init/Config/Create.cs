﻿using System.Collections.Generic;
using System.IO;
using Aurelio.Public.Classes.Entries;
using Aurelio.Public.Classes.Setting;
using Aurelio.Public.Const;
using Newtonsoft.Json;

namespace Aurelio.Public.Module.App.Init.Config;

public abstract class Create
{
    public static void Main()
    {
        Folder();
        Data();
    }

    public static void Data()
    {
        if (!File.Exists(ConfigPath.SettingDataPath))
            File.WriteAllText(ConfigPath.SettingDataPath, new SettingEntry().AsJson());
        if (!File.Exists(ConfigPath.RecentOpenDataPath))
            File.WriteAllText(ConfigPath.RecentOpenDataPath, new List<RecentOpenEntry>().AsJson());
    }

    public static void Folder()
    {
        IO.Local.Setter.TryCreateFolder(ConfigPath.UserDataRootPath);
        IO.Local.Setter.TryCreateFolder(ConfigPath.ProjectFolderPath);
    }
}