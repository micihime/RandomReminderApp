using Randy.ViewModel;

namespace Randy;

public partial class EditPage : ContentPage
{
    public EditPage(EditReminderViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}