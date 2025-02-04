using System;

namespace SmartHomeApp
{
    internal class SmartLight : SmartHome
    {
        private int brightness = 0;
        private int requiredElectricity = 20;
        private bool isOn = false;

        public int RequiredElectricity { get => requiredElectricity; }

        public int BrightnessLevel
        {
            get => brightness;
            set
            {
                if (value >= 1 && value <= 100)
                {
                    brightness = value;
                    Console.WriteLine($"Brightness set to {brightness}%.");
                }
                else
                {
                    Console.WriteLine("Brightness value must be between 1 and 100.");
                }
            }
        }

        public override void TurnOn()
        {
            if (!isOn)
            {
                isOn = true;
                ElectricityConsumption += requiredElectricity;
                Console.WriteLine("Turning on the smart light...");
                Console.WriteLine($"Smart light is now ON with {brightness}% brightness.");
            }
            else
            {
                Console.WriteLine("Smart light is already ON!");
            }
        }

        public override void TurnOff()
        {
            if (isOn)
            {
                isOn = false;
                ElectricityConsumption -= requiredElectricity;
                Console.WriteLine("Turning off the smart light...");
                Console.WriteLine("Smart light is now OFF.");
            }
            else
            {
                Console.WriteLine("Smart light is already OFF!");
            }
        }

        public override bool GetStatus()
        {
            string lightStatus = isOn ? "ON" : "OFF";
            Console.WriteLine($"Smart light status: {lightStatus} with {brightness}% brightness.");
            return isOn;
        }
    }
}