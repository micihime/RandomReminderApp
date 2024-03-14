using RandomReminderApp.Models;

namespace RandomReminderApp.Services
{
    public class ReminderService
    {
        public List<Reminder> Reminders { get; set; }

        public ReminderService()
        {
            Reminders = new List<Reminder>()
            {
                new Reminder() { Name = "Mindfulness Exercise 1", Description = "A body scan is a mindfulness exercise that involves mentally scanning your body from head to toe.", From = new TimeOnly(8, 0), To = new TimeOnly(22, 0) },
                new Reminder() { Name = "Mindfulness Exercise 2", Description = "What am I doing right now? Am I in the present moment?", From = new TimeOnly(9, 0), To = new TimeOnly(16, 30) },
                new Reminder() { Name = "Mindfulness Exercise 3", Description = "Mindful Immersion can help you let go of pressures and demands and cultivate happiness and peace in the moment.", From = new TimeOnly(17, 0), To = new TimeOnly(22, 0) }
            };
        }

        public List<Reminder> GetReminders()
        {
            return Reminders;
        }

        public void AddReminder(Reminder reminder)
        {
            Reminders.Add(reminder);
        }
    }
}