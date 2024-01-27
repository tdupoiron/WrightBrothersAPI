public class Airfield
{
    // Properties
    public string Name { get; private set; }
    public string Location { get; private set; }
    public string DatesOfUse { get; private set; }
    public string Significance { get; private set; }

    // Constructor
    public Airfield(string name, string location, string datesOfUse, string significance)
    {
        Name = name;
        Location = location;
        DatesOfUse = datesOfUse;
        Significance = significance;
    }
}