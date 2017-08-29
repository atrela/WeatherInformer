using MVVMLightWeather.Model;

namespace WeatherInformer.Model.RetrievingData
{
    internal interface IDataRetriever
    {
        CurrentWeather GetWeatherInformation(string city);
        
    }
}