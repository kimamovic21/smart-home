using System;

namespace SmartHomeApp
{
    internal class SmartAlarm : SmartHome
    {
        private bool isSmartAlarmOn = false;
        private const int requiredElectricity = 30;

        public SmartAlarm()
        {
        }

        public bool IsSmartAlarmOn { get => isSmartAlarmOn; set => isSmartAlarmOn = value; }
        public int RequiredElectricity { get => requiredElectricity; }

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

        public override bool GetStatus()
        {
            string smartAlarmStatus = isSmartAlarmOn ? "ON" : "OFF";

            Console.ForegroundColor = isSmartAlarmOn ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Current smart alarm status: {smartAlarmStatus}");

            Console.ResetColor();
            return isSmartAlarmOn;
        }
    }
}