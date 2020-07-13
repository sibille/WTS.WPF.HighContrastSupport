using WTS.WPF.HighContrastSupport.Models;

namespace WTS.WPF.HighContrastSupport.Contracts.Services
{
    public interface IThemeSelectorService
    {
        void InitializeTheme();

        void SetTheme(AppTheme theme);

        AppTheme GetCurrentTheme();
    }
}
