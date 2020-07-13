using System.Windows.Controls;

using WTS.WPF.HighContrastSupport.Contracts.Views;
using WTS.WPF.HighContrastSupport.ViewModels;

using MahApps.Metro.Controls;

namespace WTS.WPF.HighContrastSupport.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();
    }
}
