using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempF)
        {
            return ((5.0 / 9.0) * (tempF - 32));
        }

        public static double CelsiusToFahrenheit(double tempC)
        {
            return (((9.0 / 5.0) * tempC) + 32);
        }
    }
}
