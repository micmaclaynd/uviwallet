using Microsoft.UI.Xaml.Controls;
using UviWallet.Pages;

namespace UviWallet.Services {
    public static class NavigationService {
        public static Frame RootFrame { get; set; }
        public static NavigationView RootNavigationView { get; set; }

        public static void Navigate(string tag) {
            foreach (var menuItem in RootNavigationView.MenuItems) {
                var navigationViewItem = menuItem as NavigationViewItem;

                if (navigationViewItem.Tag.ToString() == tag) {
                    RootNavigationView.SelectedItem = menuItem;

                    switch (tag) {
                        case "Dashboard": {
                            RootFrame.Navigate(typeof(DashboardPage));
                            break;
                        } case "Wallets": {
                            RootFrame.Navigate(typeof(WalletsPage));
                            break;
                        } case "Tokens": {
                            RootFrame.Navigate(typeof(TokensPage));
                            break;
                        }
                    }

                    break;
                }
            }
        }
    }
}
