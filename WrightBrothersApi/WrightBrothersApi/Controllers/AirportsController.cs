using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WrightBrothersApi.Models;

namespace WrightBrothersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirportsController : ControllerBase
    {
        private static List<Airport> Airports = new List<Airport>
        {
            new Airport("KHK", "Kitty Hawk", "Kitty Hawk, NC", 1),
            new Airport("MEO", "Dare County Regional", "Manteo, NC", 1),
            new Airport("FFA", "First Flight Airport", "Kill Devil Hills, NC", 1)
        };

        [HttpGet]
        public ActionResult<List<Airport>> GetAll()
        {
            return Airports;
        }

        [HttpGet("{airportCode}")]
        public ActionResult<Airport> Get(string airportCode)
        {
            var airport = Airports.Find(a => a.AirportCode == airportCode);
            if (airport == null)
            {
                return NotFound();
            }
            return airport;
        }

        [HttpPost]
        public ActionResult<Airport> Create(Airport airport)
        {
            Airports.Add(airport);
            return CreatedAtAction(nameof(Get), new { airportCode = airport.AirportCode }, airport);
        }

        [HttpPut("{airportCode}")]
        public ActionResult Update(string airportCode, Airport updatedAirport)
        {
            var airport = Airports.Find(a => a.AirportCode == airportCode);
            if (airport == null)
            {
                return NotFound();
            }
            airport.Name = updatedAirport.Name;
            airport.Location = updatedAirport.Location;
            airport.TerminalCount = updatedAirport.TerminalCount;
            return NoContent();
        }

        [HttpDelete("{airportCode}")]
        public ActionResult Delete(string airportCode)
        {
            var airport = Airports.Find(a => a.AirportCode == airportCode);
            if (airport == null)
            {
                return NotFound();
            }
            Airports.Remove(airport);
            return NoContent();
        }
    }
}