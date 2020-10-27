using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface IWindDataService
    {
        public WindDataModel GetData();
    }
}
