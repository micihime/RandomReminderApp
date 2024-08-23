using System.Text.Json.Serialization;

namespace MonkeyFinder.Model;

public class Monkey
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public TimeOnly From { get; set; }
    public TimeOnly To { get; set; }

    //public string Name { get; set; }
    //public string Location { get; set; }
    //public string Details { get; set; }
    //public string Image { get; set; }
    //public int Population { get; set; }
    //public double Latitude { get; set; }
    //public double Longitude { get; set; }
}

[JsonSerializable(typeof(List<Monkey>))]
internal sealed partial class MonkeyContext : JsonSerializerContext
{

}
