using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.LocalNotification;
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

        if (await LocalNotificationCenter.Current.AreNotificationsEnabled() == false)
        {
            await LocalNotificationCenter.Current.RequestNotificationPermission();
        }

        var notification = new NotificationRequest
        {
            NotificationId = 100,
            Title = "Test",
            Description = "Test Description",
            ReturningData = "Dummy data", // Returning data when tapped on notification.
            Schedule =
            {
                NotifyTime = DateTime.Now.AddSeconds(30) // This is Used for Scheduling local notifications; if not specified, the notification will show immediately.
            }
        };
        await LocalNotificationCenter.Current.Show(notification);

        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}