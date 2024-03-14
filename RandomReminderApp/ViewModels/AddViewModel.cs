using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RandomReminderApp.ViewModels
{
    public partial class AddViewModel : BaseViewModel
    {
        [ObservableProperty]
        string text;

        public AddViewModel()
        {
            text = "testing viewmodel binding";               
        }

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
