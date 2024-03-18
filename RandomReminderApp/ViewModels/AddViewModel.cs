using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RandomReminderApp.Models;

namespace RandomReminderApp.ViewModels
{
    public partial class AddViewModel : BaseViewModel
    {
        [ObservableProperty]
        Reminder reminder;

        public AddViewModel()
        {
            reminder = new Reminder();
        }

        [RelayCommand]
        async Task Add()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
