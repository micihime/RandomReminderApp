using RandomReminderApp.Views;

namespace RandomReminderApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
        }
    }
}
