using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using UviWallet.Pages;

namespace UviWallet.Windows {
    public sealed partial class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();

            this.AppWindow.TitleBar.ExtendsContentIntoTitleBar = true;
            this.AppWindow.TitleBar.BackgroundColor = Colors.Transparent;
            this.AppWindow.TitleBar.ButtonBackgroundColor = Colors.Transparent;  
            this.AppWindow.TitleBar.InactiveBackgroundColor = Colors.Transparent;
        }

        private void SelectionChangeHandler(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            switch (args.SelectedItemContainer.Tag) {
                case "Dashboard": {
                    rootFrame.Navigate(typeof(DashboardPage));
                    break;
                }
                case "Wallets": {
                    rootFrame.Navigate(typeof(WalletsPage));
                    break;
                }
                case "Tokens": {
                    rootFrame.Navigate(typeof(TokensPage));
                    break;
                }
            }
        }
    }
}
