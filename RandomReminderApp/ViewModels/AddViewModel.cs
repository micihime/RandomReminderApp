using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RandomReminderApp.Models;
using RandomReminderApp.Services;

namespace RandomReminderApp.ViewModels
{
    public partial class AddViewModel : BaseViewModel
    {
        [ObservableProperty]
        Reminder reminder;

        ReminderService reminderService;

        public AddViewModel(ReminderService reminderService)
        {
            this.reminderService = reminderService;
            reminder = new Reminder();
        }

        [RelayCommand]
        async Task Add()
        {
            reminderService.AddReminder(Reminder);
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
