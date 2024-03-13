using CommunityToolkit.Mvvm.Input;
using RandomReminderApp.Models;
using RandomReminderApp.Services;
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
            LoadMonkeys();
        }

        void LoadMonkeys()
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
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}