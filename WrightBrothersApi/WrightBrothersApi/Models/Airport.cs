using System;
using System.Collections.Generic;

public class Airport
{
    // Properties
    public string AirportCode { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public int TerminalCount { get; set; }
    public List<string> Runways { get; set; }
    public List<string> Airlines { get; set; }
    public List<string> Facilities { get; set; }

    // Constructor
    public Airport(string airportCode, string name, string location, int terminalCount)
    {
        AirportCode = airportCode;
        Name = name;
        Location = location;
        TerminalCount = terminalCount;
        Runways = new List<string>();
        Airlines = new List<string>();
        Facilities = new List<string>();
    }

    // Methods
    public void AddRunway(string runway)
    {
        Runways.Add(runway);
    }

    public void AddAirline(string airline)
    {
        Airlines.Add(airline);
    }

    public void AddFacility(string facility)
    {
        Facilities.Add(facility);
    }

    // This method can be expanded to integrate with real-time flight data
    public List<Flight> GetFlights()
    {
        // Implementation depends on how you're managing flight data
        throw new NotImplementedException();
    }

    // Other methods like searchAirlines, getFacilitiesInfo, getTransportOptions can be added similarly
}
