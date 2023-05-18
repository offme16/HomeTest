using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTest
{
    public class WeatherPes
    {
        public TempInfo Main { get; set; }
        public Wind Wind { get; set; }
        public Weather[] Weather { get; set; }
    }
}
