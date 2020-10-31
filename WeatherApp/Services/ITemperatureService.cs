using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface ITemperatureService
    {
        public Task<TemperatureModel> GetTempAsync();
    }
}
