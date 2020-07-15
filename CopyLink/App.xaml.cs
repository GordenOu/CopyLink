using System;
using System.Windows;

namespace CopyLink
{
    public partial class App : Application
    {
        private void AppStartup(object sender, StartupEventArgs e)
        {
            AppDomain.CurrentDomain.UnhandledException += (sender1, e1) =>
            {
                MessageBox.Show(
                    e1.ExceptionObject.ToString(),
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error,
                    MessageBoxResult.OK,
                    MessageBoxOptions.None);
                Environment.Exit(0);
            };
        }
    }
}
