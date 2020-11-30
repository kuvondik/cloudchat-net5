using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace CloudChat.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            // Setup The App Type from Core project            
            this.RegisterSetupType<MvxWpfSetup<Core.App>>(); ;
        }
    }
}
