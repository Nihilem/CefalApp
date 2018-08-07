using System;
using System.Collections.Generic;
using System.Text;

// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SimpleLogin.Utils
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

    private const string LastUsedEmailKey= "last_email_key";
    private const string LastUsedPasswordKey= "last_password_key";
    private static readonly string SettingsDefault = string.Empty;

    #endregion


    public static string LastUsedEamil
    {
        get
        {
            return AppSettings.GetValueOrDefault(LastUsedEmailKey, SettingsDefault);
        }
        set
        {
            AppSettings.AddOrUpdateValue(LastUsedEmailKey, value);
        }
    }

        public static string LastUsedPassword
        {
            get
            {
                return AppSettings.GetValueOrDefault(LastUsedPasswordKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(LastUsedPasswordKey, value);
            }
        }


    }

}