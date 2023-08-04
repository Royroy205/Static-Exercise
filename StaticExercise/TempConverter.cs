using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempFahrenheit)
        {
            return (tempFahrenheit - 32) * 5 / 9;
        
        }

        public static double CelsiusToFahrenheit(double tempCelsius) 
        {
            return (tempCelsius * 9) / 5 + 32;
        
        }
    
    
    
    
    
    
    }
}
