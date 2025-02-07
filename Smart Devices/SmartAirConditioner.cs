using System;

namespace SmartHomeApp
{
    internal class SmartAirConditioner : SmartHome
    {
        private bool isSmartAirConditionerOn = false;
        private int temperature = 20; // Default temperature
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
                GetStatus();
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

        public void SetTemperature(int newTemperature)
        {
            if (!IsSmartAirConditionerOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The smart air conditioner is off. Please turn it on to set the temperature.");
                Console.ResetColor();
                return;
            }

            if (newTemperature < 0 || newTemperature > 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid temperature! Please set a value between 0°C and 30°C.");
            }
            else
            {
                Temperature = newTemperature;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Setting smart air conditioner temperature to {Temperature}°C...");
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