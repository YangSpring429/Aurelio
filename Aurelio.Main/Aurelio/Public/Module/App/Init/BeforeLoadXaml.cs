﻿using Aurelio.Public.Langs;
using Aurelio.Public.Module.App.Init.Config;
using Avalonia.Media;

namespace Aurelio.Public.Module.App.Init;

public abstract class BeforeLoadXaml
{
    public static void Main()
    {
        Sundry.DetectPlatform();
        Create.Main();
        Reader.Main();
        Update.Main();
        LangHelper.Current.ChangedCulture("");
        Ui.Setter.SetAccentColor(Color.Parse("#9373EE"));
    }
}