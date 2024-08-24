using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Randy.Model;
using Randy.Services;

namespace Randy.ViewModel;

[QueryProperty("Reminder", "Reminder")]
public partial class EditReminderViewModel : BaseViewModel
{
    [ObservableProperty]
    Reminder reminder;

    ReminderService reminderService;

    public EditReminderViewModel(ReminderService reminderService)
    {
        Title = "Edit Reminder";
        this.reminderService = reminderService;
        reminder = new Reminder();
    }

    [RelayCommand]
    async Task SaveAsync()
    {
        reminderService.EditReminder(Reminder);
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}