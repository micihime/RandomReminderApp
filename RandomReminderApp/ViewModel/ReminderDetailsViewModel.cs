using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Randy.Model;

namespace Randy.ViewModel;

[QueryProperty("Reminder", "Reminder")]
public partial class ReminderDetailsViewModel : BaseViewModel
{
    [ObservableProperty]
    Reminder reminder;

    public ReminderDetailsViewModel()
    {
    }

    [RelayCommand]
    async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}