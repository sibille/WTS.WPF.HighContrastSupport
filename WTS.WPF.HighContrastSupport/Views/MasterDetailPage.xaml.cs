using System.Windows.Controls;

using WTS.WPF.HighContrastSupport.ViewModels;

namespace WTS.WPF.HighContrastSupport.Views
{
    public partial class MasterDetailPage : Page
    {
        public MasterDetailPage(MasterDetailViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
