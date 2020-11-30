using CloudChat.Wpf.Application;
using ControlzEx.Theming;
using MahApps.Metro.Controls.Dialogs;

namespace CloudChat.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MvxMetroWindow
    {
        private readonly MainWindowViewModel _viewModel;

        public MainWindow()
        {
            _viewModel = new MainWindowViewModel(DialogCoordinator.Instance);
            DataContext = _viewModel;

            ThemeManager.Current.ChangeThemeColorScheme(System.Windows.Application.Current, "Teal");
            InitializeComponent();
        }
    }
}
