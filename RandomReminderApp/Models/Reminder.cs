namespace RandomReminderApp.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public TimeOnly From { get; set; }
        public TimeOnly To { get; set; }
    }
}
