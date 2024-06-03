using Microsoft.UI;
using Microsoft.UI.Xaml;

namespace UviWallet.Windows {
    public sealed partial class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();

            this.AppWindow.TitleBar.ExtendsContentIntoTitleBar = true;
            this.AppWindow.TitleBar.BackgroundColor = Colors.Transparent;
            this.AppWindow.TitleBar.ButtonBackgroundColor = Colors.Transparent;
            this.AppWindow.TitleBar.InactiveBackgroundColor = Colors.Transparent;
        }
    }
}
