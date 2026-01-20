using System;

namespace TemperatureConvertor
{
    // Production Code
    public class TemperatureConverter
    {
        // Convert celsius to Fahrenheit
        public double CtoF(double c)
        {
            return (c * 9 / 5) + 32;
        }

        // Convert Fahrenheit to Celsius
        public double FtoC(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}