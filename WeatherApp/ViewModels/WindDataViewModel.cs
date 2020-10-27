using WeatherApp.Commands;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WindDataViewModel
    {
        IWindDataService service;
        public DelegateCommand<string> GetWindDataCommand { get; set; }
        public WindDataViewModel()
        {
            GetWindDataCommand = new DelegateCommand<string>(GetWindData);
        }

        private void GetWindData(string obj)
        {
            CurrentWind = service.GetData();
        }

        public object CurrentWind { get; set; }

        public void SetWindDataService(IWindDataService _service)
        {
            service = _service;
        }
    }
}
