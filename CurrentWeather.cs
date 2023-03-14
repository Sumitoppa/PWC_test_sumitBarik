using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumit.Model
{
    class CurrentWeather
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public double WindDirection { get; set; }
        public int WeatherCode { get; set; }
        public DateTime Time { get; set; }
    }
}
