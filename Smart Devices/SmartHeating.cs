using System;

namespace SmartHomeApp
{
    internal class SmartHeating : SmartHome
    {
        private bool isSmartHeatingOn = false;
        private int temperature = 0;

        public bool IsSmartHeatingOn { get => isSmartHeatingOn; set => isSmartHeatingOn = value; }
        public int Temperature { get => temperature; set => temperature = value; }

        public SmartHeating()
        {
        }

        public SmartHeating(bool isSmartHeatingOn, int temperature)
        {
            IsSmartHeatingOn = isSmartHeatingOn;
            Temperature = temperature;
        }

        public override void TurnOn()
        {
            IsSmartHeatingOn = true;
            Console.WriteLine("\nTurning on the smart heating...");
            Console.WriteLine("Smart heating is now ON!");
        }

        public override void TurnOff()
        {
            IsSmartHeatingOn = false;
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
                Temperature = newTemperature;
                Console.WriteLine($"\nSetting smart heating temperature to {Temperature}°C...");
            }
        }

        public override void GetStatus()
        {
            string smartHeatingStatus = IsSmartHeatingOn ? "ON" : "OFF";
            Console.WriteLine("\nChecking smart heating status...");
            Console.WriteLine($"Current smart heating status: {smartHeatingStatus}");
            Console.WriteLine($"Current temperature: {Temperature}°C");
        }
    }
}