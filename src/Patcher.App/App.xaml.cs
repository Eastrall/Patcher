#if DEBUG
using System.Threading;
#endif

using System.Windows;

namespace Patcher.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
#if DEBUG
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
#endif
        }
    }
}
