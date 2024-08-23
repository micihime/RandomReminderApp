using MonkeyFinder.Model;
using System.Net.Http.Json;
using System.Text.Json;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    //HttpClient httpClient;

    List<Monkey> monkeyList = //new();
        new List<Monkey>()
        {
            new Monkey() { Name = "Mindfulness Exercise 1", Description = "A body scan is a mindfulness exercise that involves mentally scanning your body from head to toe.", From = new TimeOnly(8, 0), To = new TimeOnly(22, 0) },
            new Monkey() { Name = "Mindfulness Exercise 2", Description = "What am I doing right now? Am I in the present moment?", From = new TimeOnly(9, 0), To = new TimeOnly(16, 30) },
            new Monkey() { Name = "Mindfulness Exercise 3", Description = "Mindful Immersion can help you let go of pressures and demands and cultivate happiness and peace in the moment.", From = new TimeOnly(17, 0), To = new TimeOnly(22, 0) }
        };

    public MonkeyService()
    {
        //httpClient = new HttpClient();
    }

    public async Task<List<Monkey>> GetMonkeys()
    {
        //if (monkeyList?.Count > 0)
        //    return monkeyList;

        //var url = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/monkeydata.json";
        //var response = await httpClient.GetAsync(url);
        //if (response.IsSuccessStatusCode)
        //{
        //    monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        //}

        return monkeyList;
    }

    public async Task<List<Monkey>> GetMonkeysOffline()
    {
        if (monkeyList?.Count > 0)
            return monkeyList;
        
        using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        monkeyList = JsonSerializer.Deserialize(contents, MonkeyContext.Default.ListMonkey);

        return monkeyList;
    }
}
