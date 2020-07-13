using System.Windows.Controls;

using WTS.WPF.HighContrastSupport.ViewModels;

namespace WTS.WPF.HighContrastSupport.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
