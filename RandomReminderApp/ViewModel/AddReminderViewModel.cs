using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Randy.Model;
using Randy.Services;

namespace Randy.ViewModel;

public partial class AddReminderViewModel : BaseViewModel
{
    [ObservableProperty]
    Reminder reminder;

    ReminderService reminderService;

    public AddReminderViewModel(ReminderService reminderService)
    {
        Title = "Add New Reminder";
        this.reminderService = reminderService;
        reminder = new Reminder();
    }

    [RelayCommand]
    async Task SaveAsync()
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