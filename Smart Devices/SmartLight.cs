using System;

namespace SmartHomeApp
{
    internal class SmartLight : SmartHome
    {
        private int brightness = 50; 
        private int requiredElectricity = 20;
        private bool isSmartLightOn = false;

        public int RequiredElectricity { get => requiredElectricity; }

        public bool IsSmartLightOn
        {
            get => isSmartLightOn;
        }

        public int BrightnessLevel
        {
            get => brightness;
            set
            {
                if (value >= 1 && value <= 100)
                {
                    brightness = value;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Brightness set to {brightness}%.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Brightness value must be between 1 and 100.");
                }
                Console.ResetColor();
            }
        }

        public override void TurnOn()
        {
            if (!isSmartLightOn)
            {
                isSmartLightOn = true;
                ElectricityConsumption += requiredElectricity;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Smart light is now ON!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart light is already ON!");
            }
            Console.ResetColor();
        }

        public override void TurnOff()
        {
            if (isSmartLightOn)
            {
                isSmartLightOn = false;
                ElectricityConsumption -= requiredElectricity;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart light is now OFF.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart light is already OFF!");
            }
            Console.ResetColor();
        }

        public void SetBrightnessLevel()
        {
            if (!isSmartLightOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The smart light is OFF. Please turn it on to set the brightness.");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Enter the desired brightness (1-100):");
            string? brightnessInput = Console.ReadLine();

            if (int.TryParse(brightnessInput, out int brightness) && brightness >= 1 && brightness <= 100)
            {
                BrightnessLevel = brightness;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid brightness value. Please enter a number between 1 and 100.");
                Console.ResetColor();
            }
        }

        public override bool GetStatus()
        {
            string lightStatus = isSmartLightOn ? "ON" : "OFF";

            Console.ForegroundColor = isSmartLightOn ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Smart light status: {lightStatus} with {brightness}% brightness.");

            Console.ResetColor();

            return isSmartLightOn;
        }
    }
}