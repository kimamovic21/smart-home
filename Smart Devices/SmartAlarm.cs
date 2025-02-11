using System;

namespace SmartHomeApp
{
    internal class SmartAlarm : SmartHome
    {
        private bool isSmartAlarmOn = false;
        private const int requiredElectricity = 30;
        private int decibelLevel = 80;

        public SmartAlarm() { }

        public bool IsSmartAlarmOn { get => isSmartAlarmOn; set => isSmartAlarmOn = value; }
        public int RequiredElectricity { get => requiredElectricity; }
        public int DecibelLevel { get => decibelLevel; }

        public override void TurnOn()
        {
            if (isSmartAlarmOn)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart alarm is already ON!");
            }
            else
            {
                isSmartAlarmOn = true;
                ElectricityConsumption += requiredElectricity;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart alarm is now ON!");
            }

            Console.ResetColor();
        }

        public override void TurnOff()
        {
            if (isSmartAlarmOn)
            {
                isSmartAlarmOn = false;
                ElectricityConsumption -= requiredElectricity;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart alarm is now OFF!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart alarm is already OFF!");
            }

            Console.ResetColor();
        }

        public void SetDecibelLevel()
        {
            if (!isSmartAlarmOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The smart alarm is OFF. Please turn it on to set the decibel level. ");
                Console.ResetColor();
                return;
            }

            Console.Write("Enter decibel level (80-120): ");
            if (int.TryParse(Console.ReadLine(), out int smartAlarmDecibelLevel))
            {
                if (smartAlarmDecibelLevel < 80 || smartAlarmDecibelLevel > 120)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a decibel level between 80 and 120.");
                }
                else
                {
                    decibelLevel = smartAlarmDecibelLevel;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Smart alarm decibel level set to {decibelLevel} dB.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ResetColor();
        }

        public override bool GetStatus()
        {
            string smartAlarmStatus = isSmartAlarmOn ? "ON" : "OFF";

            Console.ForegroundColor = isSmartAlarmOn ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Current smart alarm status: {smartAlarmStatus}");
            Console.WriteLine($"Decibel level: {decibelLevel} dB");

            Console.ResetColor();
            return isSmartAlarmOn;
        }
    }
}