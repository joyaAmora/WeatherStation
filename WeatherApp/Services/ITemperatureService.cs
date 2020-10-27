using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface ITemperatureService
    {
        public TemperatureModel GetData();
    }
}
