using System;
using System.Windows;

using ControlzEx.Theming;

using WTS.WPF.HighContrastSupport.Contracts.Services;
using WTS.WPF.HighContrastSupport.Models;
using MahApps.Metro.Theming;

namespace WTS.WPF.HighContrastSupport.Services
{
    public class ThemeSelectorService : IThemeSelectorService
    {
        private bool IsHighContrastActive
                        => SystemParameters.HighContrast;

        public ThemeSelectorService()
        {
            ThemeManager.Current.AddLibraryTheme(new LibraryTheme(
                                                  new Uri("pack://application:,,,/HC.Dark.Blue.xaml"),
                                                  MahAppsLibraryThemeProvider.DefaultInstance));
            ThemeManager.Current.AddLibraryTheme(new LibraryTheme(
                                                    new Uri("pack://application:,,,/HC.Light.Blue.xaml"),
                                                    MahAppsLibraryThemeProvider.DefaultInstance));

            ThemeManager.Current.ThemeChanged += OnThemeChanged;
        }

        public void InitializeTheme()
        {
            var theme = GetCurrentTheme();
            SetTheme(theme);
        }

        public void SetTheme(AppTheme theme)
        {
            if (theme == AppTheme.Default)
            {
                ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncAll;
                ThemeManager.Current.SyncTheme();
            }
            else
            {
                ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncWithHighContrast;
                ThemeManager.Current.SyncTheme();
                ThemeManager.Current.ChangeTheme(Application.Current, $"{theme}.Blue", IsHighContrastActive);
            }

            App.Current.Properties["Theme"] = theme.ToString();
        }

        public AppTheme GetCurrentTheme()
        {
            if (App.Current.Properties.Contains("Theme"))
            {
                var themeName = App.Current.Properties["Theme"].ToString();
                Enum.TryParse(themeName, out AppTheme theme);
                return theme;
            }

            return AppTheme.Default;
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
        }
    }
}
