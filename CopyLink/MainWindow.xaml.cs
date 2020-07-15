using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using CopyLink.Resources;

namespace CopyLink
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var args = Environment.GetCommandLineArgs();
            string url = args.LastOrDefault();
            Clipboard.SetText(url);
            var notifyIcon = new System.Windows.Forms.NotifyIcon
            {
                Icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location)
            };
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(
                3000,
                "CopyLink",
                string.Format(Strings.Message, url),
                System.Windows.Forms.ToolTipIcon.None);
            Application.Current.Shutdown();
        }
    }
}
