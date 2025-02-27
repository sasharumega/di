﻿using TagCloudContainer.Interfaces;
using TagCloudGUI.Settings;

namespace TagCloudGUI.Interfaces
{
    public interface IPresetsSettings
    {
        Switcher Filtered { get; set; }
        Switcher ToLowerCase { get; set; }
        IFileReader Reader { get; }
        IFileParser Parser { get; }
        IWordProcessor Formatter { get; }
        IFrequencyCounter FrequencyCounter { get; }
        IFontSizer FontSizer { get; }
        ICloudDrawer Drawer { get; }

    }
}
