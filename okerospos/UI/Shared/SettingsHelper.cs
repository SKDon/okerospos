using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace OBS.Pos.UI.Shared
{
    public static class SettingsHelper
    {
        public static string GetSetting(string settingName)
        {
            try
            {
                return ConfigurationManager.AppSettings[settingName];
            }
            catch { return string.Empty; }
        }
    }

    public class SettingKeys
    {
        public const string DEFAULT_USER_INCLUDECLASSNAMES = "SEC_UserIncludeClassNames";
    }
}
