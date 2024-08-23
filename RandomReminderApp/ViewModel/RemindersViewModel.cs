using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Randy.Model;
using Randy.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Randy.ViewModel;

public partial class RemindersViewModel : BaseViewModel
{
    ReminderService reminderService;

    public ObservableCollection<Reminder> Monkeys { get; } = new();

    [ObservableProperty]
    bool isRefreshing;

    public RemindersViewModel(ReminderService reminderService)
    {
        Title = "Randy";
        this.reminderService = reminderService;
    }

    [RelayCommand]
    async Task GoToDetailsAsync(Reminder reminder)
    {
        if (reminder is null)
            return;

        await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
            new Dictionary<string, object>
            {
                { "Reminder", reminder }
            });
    }

    [RelayCommand]
    async Task GetRemindersAsync()
    {
        if (IsBusy)
            return;

        try
        {
            //if (connectivity.NetworkAccess != NetworkAccess.Internet)
            //{
            //    await Shell.Current.DisplayAlert("Internet Issue",
            //        "Check your internet and try again.", "OK");

            //    return;
            //}

            IsBusy = true;
            var reminders = await reminderService.GetReminders();

            if (Monkeys.Count != 0)
                Monkeys.Clear();

            foreach (var reminder in reminders)
                Monkeys.Add(reminder);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",
                $"Unable to get reminders: {ex.Message}", "OK");
        }
        finally
        {
            IsRefreshing = false;
            IsBusy = false;
        }
    }
}