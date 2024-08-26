using Randy.Model;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Randy.Services;

public class ReminderService
{
    //HttpClient httpClient;

    List<Reminder> reminderList = //new();
        new List<Reminder>()
        {
            new Reminder() { Name = "Mindfulness Exercise 1", Summary = "Short summary", Description = "A body scan is a mindfulness exercise that involves mentally scanning your body from head to toe.", From = new TimeOnly(8, 0), To = new TimeOnly(22, 0) },
            new Reminder() { Name = "Mindfulness Exercise 2", Summary = "Short summary", Description = "What am I doing right now? Am I in the present moment?", From = new TimeOnly(9, 0), To = new TimeOnly(16, 30) },
            new Reminder() { Name = "Mindfulness Exercise 3", Summary = "Short summary", Description = "Mindful Immersion can help you let go of pressures and demands and cultivate happiness and peace in the moment.", From = new TimeOnly(17, 0), To = new TimeOnly(22, 0) }
        };

    public ReminderService()
    {
        //httpClient = new HttpClient();
    }

    public async Task<List<Reminder>> GetReminders()
    {
        //if (reminderList?.Count > 0)
        //    return reminderList;

        //var url = "https://raw.githubusercontent.com/jamesmontemagno/app-reminders/master/RemindersApp/reminderdata.json";
        //var response = await httpClient.GetAsync(url);
        //if (response.IsSuccessStatusCode)
        //{
        //    reminderList = await response.Content.ReadFromJsonAsync<List<Reminder>>();
        //}

        return reminderList;
    }

    public void AddReminder(Reminder reminder)
    {
        reminderList.Add(reminder);
    }

    public void EditReminder(Reminder reminder)
    {
        var remonderToEdit = reminderList.Where(x => x.Id == reminder.Id).FirstOrDefault();
        if (remonderToEdit != null)
        {
            remonderToEdit.Name = reminder.Name;
            remonderToEdit.Summary = reminder.Summary;
            remonderToEdit.Description = reminder.Description;
            remonderToEdit.From = reminder.From;
            remonderToEdit.To = reminder.To;
        }
    }

    public void DeleteReminder(int id) { }
}
