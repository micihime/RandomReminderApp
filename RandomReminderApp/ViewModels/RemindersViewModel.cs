using RandomReminderApp.Models;
using System.Collections.ObjectModel;

namespace RandomReminderApp.ViewModels
{
    public partial class RemindersViewModel : BaseViewModel
    {
        public ObservableCollection<Reminder> Reminders { get; } = new();

        public RemindersViewModel()
        {
            Title = "Reminders";
        }
    }
}
