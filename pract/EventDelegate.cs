// using System;
// namespace EventDelegate;
// class TemperatureSensor
// {
//     // Declare an event of type EventHandler
//     public event EventHandler OnTemperatureThresholdExceeded();

//     // Set the temperature threshold to 25 degrees Celsius
//     private const int TemperatureThreshold = 25;

//     // Keep track of the temperature readings
//     private int[] temperatureReadings = new int[10];
//     private int currentIndex = 0;

//     public void AddTemperatureReading(int temperature)
//     {
//         // Add the temperature reading to the array
//         temperatureReadings[currentIndex++] = temperature;

//         // Check if the temperature exceeds the threshold
//         if (temperature > TemperatureThreshold && OnTemperatureThresholdExceeded != null)
//         {
//             // Raise the temperature threshold exceeded event
//             OnTemperatureThresholdExceeded("Temperature reading " + currentIndex + " exceeded threshold");
//         }
//     }
// }
// class Program
// {
//     delegate void EventHandler(string message);

//     static void Main()
//     {
//         // Create a new instance of a temperature sensor
//         TemperatureSensor sensor = new TemperatureSensor();

//         // Register an event handler for the temperature threshold exceeded event
//         sensor.OnTemperatureThresholdExceeded += new EventHandler(OnTemperatureThresholdExceeded);

//         // Simulate adding temperature readings to the sensor
//         for (int i = 0; i < 10; i++)
//         {
//             sensor.AddTemperatureReading(20 + i);
//         }
//     }

//     static void OnTemperatureThresholdExceeded(string message)
//     {
//         Console.WriteLine("Temperature threshold exceeded: {0}", message);
//     }
// }

