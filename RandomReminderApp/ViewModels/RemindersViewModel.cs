using CommunityToolkit.Mvvm.Input;
using RandomReminderApp.Models;
using RandomReminderApp.Services;
using RandomReminderApp.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace RandomReminderApp.ViewModels
{
    public partial class RemindersViewModel : BaseViewModel
    {
        ReminderService reminderService;

        public ObservableCollection<Reminder> Reminders { get; } = new();

        public RemindersViewModel(ReminderService reminderService)
        {
            Title = "Reminders";
            this.reminderService = reminderService;
            LoadReminders();
        }

        void LoadReminders()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var reminders = reminderService.GetReminders();

                if (Reminders.Count != 0)
                    Reminders.Clear();

                foreach (var reminder in reminders)
                    Reminders.Add(reminder);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                //await Shell.Current.DisplayAlert("Error!", $"Unable to get reminders: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        async Task CreateNew()
        {
            await Shell.Current.GoToAsync($"{nameof(AddPage)}");
        }
    }
}