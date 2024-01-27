public class Airfield
{
    // Properties
    public string Name { get; set; }
    public string Location { get; set; }
    public string DatesOfUse { get; set; }
    public string Significance { get; set; }

    // Constructor
    public Airfield(string name, string location, string datesOfUse, string significance)
    {
        Name = name;
        Location = location;
        DatesOfUse = datesOfUse;
        Significance = significance;
    }
}