using RandomReminderApp.ViewModels;

namespace RandomReminderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(RemindersViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
