namespace SpaceWeatherAPI.Controllers
{
    public class TempLog
    {
        private static int LogCount = 0;
        public int PlanetId { get; set; }
        public int LogId { get; }
        public string Temp {  get; set; }

        public TempLog(int _planetid, string _temp)
        {
            LogId = LogCount;
            LogCount++;
            PlanetId = _planetid;
            Temp = _temp;
        }
    }
}
