namespace SpaceWeatherAPI.Controllers
{
    public class Planet
    {
        static private int PlanetCount = 0;
        public int Id { get; }
        public string Name { get; set; }

        public Planet(string _name)
        {
            Id = PlanetCount;
            PlanetCount++;

            Name = _name;
        }
}
    }
