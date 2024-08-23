using Randy.ViewModel;

namespace Randy;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(ReminderDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}