using System.Windows.Controls;

using WTS.WPF.HighContrastSupport.ViewModels;

namespace WTS.WPF.HighContrastSupport.Views
{
    public partial class MainPage : Page
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
