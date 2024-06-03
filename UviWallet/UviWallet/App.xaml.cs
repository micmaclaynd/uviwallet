﻿using Microsoft.UI.Xaml;

namespace UviWallet {
    public partial class App : Application {
        public App() {
            this.InitializeComponent();
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args) {
            m_window = new Windows.MainWindow();
            m_window.Activate();
        }

        private Window m_window;
    }
}
