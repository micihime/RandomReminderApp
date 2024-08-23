using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RandomReminderApp.Models;

namespace RandomReminderApp.ViewModels
{
    [QueryProperty("Reminder", "Reminder")]
    public partial class DetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Reminder reminder;

        public DetailsViewModel()
        {
        }

        [RelayCommand]
        async Task GoBackAsync()
        {
            var a = reminder.Name;
            await Shell.Current.GoToAsync("..");
        }
    }
}