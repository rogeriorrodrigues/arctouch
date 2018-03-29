// Helpers/Settings.cs
using System.Globalization;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace movies.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

    #region Setting Constants
        private const string APIBASE = "https://api.themoviedb.org/3";
        private const string APIKey = "1f54bd990f1cdfb230adb312546d765d";
        private static string Lang = CultureInfo.CurrentUICulture.Name;

        private static readonly string AccessTokenDefault = string.Empty;
        private static readonly string LangName = string.Empty;
        private static readonly string ApiBaseDefault = string.Empty;
      
    #endregion
    public static string ApiKey
       {
            get => AppSettings.GetValueOrDefault<string>(AccessTokenDefault, APIKey);
            set => AppSettings.AddOrUpdateValue<string>(value, APIKey);
        }
        public static string Language
        {
            get => AppSettings.GetValueOrDefault<string>(LangName, Lang);
            set => AppSettings.AddOrUpdateValue<string>(value, Lang);
        }
    public static string ApiUrl
    {
            get => AppSettings.GetValueOrDefault<string>(ApiBaseDefault, APIBASE);
            set => AppSettings.AddOrUpdateValue<string>(value, APIBASE);
    }

  }
}