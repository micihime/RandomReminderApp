using RandomReminderApp.ViewModels;

namespace RandomReminderApp.Views;

public partial class AddPage : ContentPage
{
    public AddPage(AddViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}