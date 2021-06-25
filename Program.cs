using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            while (isValid)
            {
                Console.WriteLine("Select Conversion type 1 or 2");
                Console.WriteLine("1: Fahrenheit to Celsius");
                Console.WriteLine("2: Celsius to Fahrenheit");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Please enter a Temperature to convert to Celsius: ");
                    var tempF = double.Parse(Console.ReadLine());
                    Console.WriteLine(TempConverter.FahrenheitToCelsius(tempF));
                }
                else if (input == "2")
                {
                    Console.Write("Please enter a Temperature to convert to Fahrenheit: ");
                    var tempC = double.Parse(Console.ReadLine());
                    Console.WriteLine(TempConverter.CelsiusToFahrenheit(tempC));
                }
                else Console.WriteLine($"Hmm, I don't understand {input}, please type 1 or 2");
            }



            //Console.WriteLine(TempConverter.FahrenheitToCelsius(32));
            //Console.WriteLine(TempConverter.CelsiusToFahrenheit(0));
        }
    }
}
