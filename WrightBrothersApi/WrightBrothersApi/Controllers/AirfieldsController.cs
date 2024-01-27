using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WrightBrothersApi.Models;

namespace WrightBrothersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WrightBrothersAirfieldsController : ControllerBase
    {
        private static readonly List<Airfield> Airfields = new List<Airfield>
        {
            new Airfield("Huffman Prairie", "Dayton, Ohio", "1904-1905", "Second field used by the Wright Brothers"),
            new Airfield("Kill Devil Hills", "Kitty Hawk, North Carolina", "1900-1903", "First field used by the Wright Brothers"),
            new Airfield("Simms Station", "Dayton, Ohio", "1905-1909", "Third field used by the Wright Brothers"),
            new Airfield("Wright Brothers Field", "Dayton, Ohio", "1910-1915", "Fourth field used by the Wright Brothers")
        };

        [HttpGet]
        public ActionResult<List<Airfield>> GetAll()
        {
            return Airfields;
        }

        [HttpGet("{name}")]
        public ActionResult<Airfield> GetByName(string name)
        {
            var airfield = Airfields.Find(a => a.Name == name);
            if (airfield == null)
            {
                return NotFound();
            }
            return airfield;
        }

        [HttpPost]
        public ActionResult<Airfield> Create(Airfield airfield)
        {
            Airfields.Add(airfield);
            return CreatedAtAction(nameof(GetByName), new { name = airfield.Name }, airfield);
        }

        [HttpPut("{name}")]
        public ActionResult Update(string name, Airfield updatedAirfield)
        {
            var airfield = Airfields.Find(a => a.Name == name);
            if (airfield == null)
            {
                return NotFound();
            }
            airfield.Name = updatedAirfield.Name; // Fix: Make the 'Name' property accessible by adding a public set accessor in the 'Airfield' class.
            airfield.Location = updatedAirfield.Location;
            airfield.DatesOfUse = updatedAirfield.DatesOfUse;
            airfield.Significance = updatedAirfield.Significance;
            return NoContent();
        }

        [HttpDelete("{name}")]
        public ActionResult Delete(string name)
        {
            var airfield = Airfields.Find(a => a.Name == name);
            if (airfield == null)
            {
                return NotFound();
            }
            Airfields.Remove(airfield);
            return NoContent();
        }
    }
}