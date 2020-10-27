using System;
using WeatherApp.Commands;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        ITemperatureService TemperatureService;
        public double CelsiusInFarenheit(double c)
        {
            return c;
        }
        public double FarenheitInCelsius(double f)
        {
            return f;
        }
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        /// 
        public DelegateCommand<string> GetTempCommand { get; set; }

        public TemperatureViewModel()
        {
           
        }

        public bool CanGetTemp()
        {
            throw new NotImplementedException();
        }

        public void SetTemperatureService(ITemperatureService _service)
        {
            TemperatureService = _service;
        }
    }
}
