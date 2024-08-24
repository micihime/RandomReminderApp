using Randy.ViewModel;

namespace Randy;

public partial class AddPage : ContentPage
{
    public AddPage(AddReminderViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}