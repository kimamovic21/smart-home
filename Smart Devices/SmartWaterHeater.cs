using System;

namespace SmartHomeApp
{
    internal class SmartWaterHeater : SmartHome
    {
        private bool isSmartWaterHeaterOn = false;
        private int temperature = 30;
        private int requiredElectricity = 100;

        public int RequiredElectricity { get => requiredElectricity; }
        public bool IsSmartWaterHeaterOn { get => isSmartWaterHeaterOn; set => isSmartWaterHeaterOn = value; }
        public int Temperature { get => temperature; set => temperature = value; }

        public SmartWaterHeater() { }

        public SmartWaterHeater(bool isSmartWaterHeaterOn, int temperature)
        {
            IsSmartWaterHeaterOn = isSmartWaterHeaterOn;
            Temperature = temperature;
        }

        public override void TurnOn()
        {
            if (!IsSmartWaterHeaterOn)
            {
                IsSmartWaterHeaterOn = true;
                ElectricityConsumption += RequiredElectricity;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart water heater is now ON!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart water heater is already ON!");
            }
            Console.ResetColor();
        }

        public override void TurnOff()
        {
            if (IsSmartWaterHeaterOn)
            {
                IsSmartWaterHeaterOn = false;
                ElectricityConsumption -= RequiredElectricity;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart water heater is now OFF!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart water heater is already OFF!");
            }
            Console.ResetColor();
        }

        public void SetTemperature()
        {
            if (!IsSmartWaterHeaterOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The smart water heater is OFF. Please turn it on to set the temperature.");
            }
            else
            {
                Console.WriteLine("Enter the desired temperature (20-50°C):");
                string? temperatureInput = Console.ReadLine();
                if (int.TryParse(temperatureInput, out int newTemperature) && newTemperature >= 20 && newTemperature <= 50)
                {
                    Temperature = newTemperature;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Smart water heater temperature set to {Temperature}°C.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid temperature! Please set a value between 20°C and 50°C.");
                }
            }
            Console.ResetColor();
        }

        public override bool GetStatus()
        {
            Console.ForegroundColor = IsSmartWaterHeaterOn ? ConsoleColor.Green : ConsoleColor.Red;

            string smartWaterHeaterStatus = IsSmartWaterHeaterOn ? "ON" : "OFF";
            Console.WriteLine($"Current smart water heater status: {smartWaterHeaterStatus}");
            Console.WriteLine($"Current temperature: {Temperature}°C");

            Console.ResetColor();
            return IsSmartWaterHeaterOn;
        }
    }
}