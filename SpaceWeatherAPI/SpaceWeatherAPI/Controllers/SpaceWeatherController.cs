using Microsoft.AspNetCore.Mvc;
using SpaceWeatherAPI.Controllers;
using System.Numerics;

namespace SpaceWeatherAPI.Controllers
{
    [Route("api/v1/planets")]
    [ApiController]
    public class SpaceWeatherController : ControllerBase
    {
        // GET api/v1/planets
        [HttpGet]
        public IActionResult GetPlanets()
        {
            List<Planet> Planets =  CreatePlanets();
            return Ok(Planets);
        }

        // GET api/v1/planets/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            List<Planet> Planets = CreatePlanets();
            return Ok(Planets.Find(x => x.Id == id));
        }

        // GET api/v1/planets/templog/id
        [HttpGet("templog/{id}")]
        public IActionResult GetTempByPlanetId(int id)
        {
            List<TempLog> tempLogs = CreateTempLogs();
            return Ok(tempLogs.Find(x => x.PlanetId == id));
        }

        // POST api/v1/planets
        [HttpPost]
        public IActionResult Post(Planet planet)
        {
            List<Planet> Planets = CreatePlanets();
            Planets.Add(planet);
            return CreatedAtAction(nameof(GetById), new { id = planet.Id }, planet);
        }

        // DELETE api/v1/planets
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            List<Planet> Planets = CreatePlanets();
            Planets.Remove(Planets.Where(x => x.Id == id).First());
            return NoContent();
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<Planet> CreatePlanets()
        {
            Planet Mars = new("Mars");
            Planet Pluto = new("Pluto");
            Planet Neptune = new("Neptune");

            List<Planet> Planets = new();
            Planets.Add(Mars);
            Planets.Add(Pluto);
            Planets.Add(Neptune);

            return Planets;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public List<TempLog> CreateTempLogs()
        {
            Planet Mars = new("Mars");
            Planet Pluto = new("Pluto");
            Planet Neptune = new("Neptune");

            TempLog MarsTemp1 = new(Mars.Id, "-32");
            TempLog MarsTemp2 = new(Mars.Id, "-67");
            TempLog MarsTemp3 = new(Mars.Id, "23");

            TempLog PlutoTemp1 = new(Pluto.Id, "-312");
            TempLog PlutoTemp2 = new(Pluto.Id, "-400");
            TempLog PlutoTemp3 = new(Pluto.Id, "-163");

            TempLog NeptuneTemp1 = new(Neptune.Id, "160");
            TempLog NeptuneTemp2 = new(Neptune.Id, "250");
            TempLog NeptuneTemp3 = new(Neptune.Id, "175");

            List<Planet> Planets = new();
            Planets.Add(Mars);
            Planets.Add(Pluto);
            Planets.Add(Neptune);

            List<TempLog> tempLogs = new();
            tempLogs.Add(MarsTemp1);
            tempLogs.Add(MarsTemp2);
            tempLogs.Add(MarsTemp3);
            tempLogs.Add(PlutoTemp1);
            tempLogs.Add(PlutoTemp2);
            tempLogs.Add(PlutoTemp3);
            tempLogs.Add(NeptuneTemp1);
            tempLogs.Add(NeptuneTemp2);
            tempLogs.Add(NeptuneTemp3);

            return tempLogs;
        }
    }
}
