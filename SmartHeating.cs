using System;

namespace SmartHomeApp
{
    internal class SmartHeating
    {
        private bool isSmartHeatingOn;
        private int temperature;

        public SmartHeating()
        {
            temperature = 20; 
        }

        public void TurnOnSmartHeating()
        {
            isSmartHeatingOn = true;
            Console.WriteLine("\nTurning on the smart heating...");
            Console.WriteLine("Smart heating is now ON!");
        }

        public void TurnOffSmartHeating()
        {
            isSmartHeatingOn = false;
            Console.WriteLine("\nTurning off the smart heating...");
            Console.WriteLine("Smart heating is now OFF!");
        }

        public void SetTemperature(int newTemperature)
        {
            if (newTemperature < 0 || newTemperature > 30)
            {
                Console.WriteLine("\nInvalid temperature! Please set a value between 0°C and 30°C.");
            }
            else
            {
                temperature = newTemperature;
                Console.WriteLine($"\nSetting smart heating temperature to {temperature}°C...");
            }
        }

        public void GetSmartHeatingStatus()
        {
            string smartHeatingStatus = isSmartHeatingOn ? "ON" : "OFF";
            Console.WriteLine("\nChecking smart heating status...");
            Console.WriteLine($"Current smart heating status: {smartHeatingStatus}");
            Console.WriteLine($"Current temperature: {temperature}°C");
        }
    }
}