using System;
using System.Windows.Navigation;
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
        public object CurrentTemp { get; private set; }

        public TemperatureViewModel()
        {

            GetTempCommand = new DelegateCommand<string>(GetTemp, canExecuteTemp);
        }

        private bool canExecuteTemp(string obj)
        {
            if (TemperatureService == null)
            {
                return false;
            }
            else
                return true;
        }

        private void GetTemp(string obj)
        {
            //CurrentTemp = TemperatureService.GetData();
        }

        //public void SetTemperatureService(ITemperatureService _service)
        //{
        //    TemperatureService = _service;
        //}
    }
}
