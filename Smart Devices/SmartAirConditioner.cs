using System;

namespace SmartHomeApp
{
    internal class SmartAirConditioner : SmartHome
    {
        private bool isSmartAirConditionerOn = false;
        private int temperature = 20;
        private int requiredElectricity = 100;

        public int RequiredElectricity { get => requiredElectricity; }
        public bool IsSmartAirConditionerOn { get => isSmartAirConditionerOn; set => isSmartAirConditionerOn = value; }
        public int Temperature { get => temperature; set => temperature = value; }

        public SmartAirConditioner() { }

        public SmartAirConditioner(bool isSmartAirConditionerOn, int temperature)
        {
            IsSmartAirConditionerOn = isSmartAirConditionerOn;
            Temperature = temperature;
        }

        public override void TurnOn()
        {
            if (!IsSmartAirConditionerOn)
            {
                IsSmartAirConditionerOn = true;
                ElectricityConsumption += RequiredElectricity;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart air conditioner is now ON!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart air conditioner is already ON!");
            }
            Console.ResetColor();
        }

        public override void TurnOff()
        {
            if (IsSmartAirConditionerOn)
            {
                IsSmartAirConditionerOn = false;
                ElectricityConsumption -= RequiredElectricity;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart air conditioner is now OFF!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart air conditioner is already OFF!");
            }
            Console.ResetColor();
        }

        public void SetTemperature()
        {
            if (!IsSmartAirConditionerOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The smart air conditioner is OFF. Please turn it ON to set the temperature.");
                Console.ResetColor();
                return;
            }

            Console.Write("Enter the desired temperature (between 10°C and 30°C): ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int newTemperature))
            {
                if (newTemperature < 10 || newTemperature > 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid temperature! Please set a value between 10°C and 30°C.");
                }
                else
                {
                    Temperature = newTemperature;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Setting smart air conditioner temperature to {Temperature}°C...");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a valid temperature.");
            }
            Console.ResetColor();
        }

        public override bool GetStatus()
        {
            Console.ForegroundColor = IsSmartAirConditionerOn ? ConsoleColor.Green : ConsoleColor.Red;

            Console.WriteLine($"Current smart air conditioner status: {(IsSmartAirConditionerOn ? "ON" : "OFF")}");
            Console.WriteLine($"Current smart air conditioner temperature: {Temperature}°C");

            Console.ResetColor();

            return IsSmartAirConditionerOn;
        }
    }
}