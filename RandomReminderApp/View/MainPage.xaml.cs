using Randy.ViewModel;

namespace Randy.View;

public partial class MainPage : ContentPage
{
	public MainPage(RemindersViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}