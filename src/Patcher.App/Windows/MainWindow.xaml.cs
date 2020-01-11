using Patcher.App.ViewModels;
using System.Windows;

namespace Patcher.App.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _viewModel;

        /// <summary>
        /// Creates a new <see cref="MainWindow"/> instance.
        /// </summary>
        public MainWindow()
        {
            this._viewModel = new MainViewModel();
            
            InitializeComponent();
            DataContext = _viewModel;
        }
    }
}
