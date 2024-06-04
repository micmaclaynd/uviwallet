using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using UviWallet.Pages;
using UviWallet.Services;

namespace UviWallet.Windows {
    public sealed partial class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();

            this.AppWindow.TitleBar.ExtendsContentIntoTitleBar = true;
            this.AppWindow.TitleBar.BackgroundColor = Colors.Transparent;
            this.AppWindow.TitleBar.ButtonBackgroundColor = Colors.Transparent;
            this.AppWindow.TitleBar.InactiveBackgroundColor = Colors.Transparent;

            NavigationService.RootFrame = rootFrame;
            NavigationService.RootNavigationView = rootNavigationView;

            NavigationService.Navigate("Dashboard");
        }

        private void SelectionChangeHandler(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            NavigationService.Navigate(args.SelectedItemContainer.Tag.ToString());
        }
    }
}
