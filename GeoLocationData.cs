using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumit.Model
{
    class GeoLocationData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double GenerationTime_MS { get; set; }
        public int UTC_Offset_Seconds { get; set; }
        public string TimeZone { get; set; }
        public string TimeZone_Abbreviation { get; set; }
        public double Elevation { get; set; }
        public CurrentWeather Current_Weather { get; set; }
    }
}
