using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //public string condition;
        public int temperature;
        public List<String> weatherConditions;
        public string predictedForecast;

        public Weather()
        {
            //condition = "";
            temperature = 0;
            weatherConditions = new List<string>();
            predictedForecast = "";
            CreateWeatherConditions();
        }

        public void CreateWeatherConditions()
        {
            weatherConditions.Add("Rainy");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Calm");
            
        }

        public int GenerateRandomTemperature()
        {
            Random random = new Random();
            return random.Next(40, 95);
        }

        public int GenerateRandomWeatherCondition()
        {
            Random random = new Random();
            return random.Next(0, weatherConditions.Count);
        }

        public void GenerateWeatherPrediction()
        {
            temperature = GenerateRandomTemperature();
            predictedForecast = weatherConditions[GenerateRandomWeatherCondition()];
        }
    }
    
}
