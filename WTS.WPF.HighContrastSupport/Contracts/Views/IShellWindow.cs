using System.Windows.Controls;

namespace WTS.WPF.HighContrastSupport.Contracts.Views
{
    public interface IShellWindow
    {
        Frame GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}
