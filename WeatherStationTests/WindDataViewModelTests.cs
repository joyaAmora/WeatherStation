using Moq;
using WeatherApp.Models;
using WeatherApp.Services;
using WeatherApp.ViewModels;
using Xunit;

namespace WeatherStationTests
{
    public class WindDataViewModelTests
    {
        WindDataViewModel _sut = new WindDataViewModel();

        [Fact]
        public void GetWindData_HaveCurrentWindWhenExecuted_ShouldPass()
        {
            //Arrange
            var _mock = new Mock<IWindDataService>();
            _mock.Setup(x => x.GetData()).Returns(new WindDataModel());

            _sut.SetWindDataService(_mock.Object);

            //Action
            _sut.GetWindDataCommand.Execute(string.Empty);
            var actualWindData = _sut.CurrentWind;

            //Assert
            Assert.NotNull(actualWindData);
        }
    }
}
