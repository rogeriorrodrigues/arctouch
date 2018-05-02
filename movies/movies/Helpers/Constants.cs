using System;
using System.Globalization;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace movies.Helpers
{



    public static class Constants
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private const string APIKey = "1f54bd990f1cdfb230adb312546d765d";
        private static string Lang = CultureInfo.CurrentUICulture.Name;
        private static readonly string AccessTokenDefault = string.Empty;
        private static readonly string LangName = string.Empty;

        public static string ApiKey
        {
            get => AppSettings.GetValueOrDefault<string>(APIKey, AccessTokenDefault);
            set => AppSettings.AddOrUpdateValue<string>(APIKey, value);
        }

        public static string Language
        {
            get => AppSettings.GetValueOrDefault<string>(Lang, LangName);
            set => AppSettings.AddOrUpdateValue<string>(Lang, value);
        }

    }
}




