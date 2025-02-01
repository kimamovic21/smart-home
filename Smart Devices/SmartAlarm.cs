using System;

namespace SmartHomeApp
{
    internal class SmartAlarm : SmartHome
    {
        private bool isSmartAlarmOn = false;

        public SmartAlarm(bool isSmartAlarmOn)
        {
            IsSmartAlarmOn = isSmartAlarmOn;
        }

        public SmartAlarm()
        {
        }

        public bool IsSmartAlarmOn { get => isSmartAlarmOn; set => isSmartAlarmOn = value; }

        public override void TurnOn()
        {
            if (isSmartAlarmOn == true)
            {
                Console.WriteLine("Smart alarm is already ON!");
            }
            else
            {
                isSmartAlarmOn = true;
                Console.WriteLine("Turning on the smart alarm...");
                Console.WriteLine("Smart alarm is now ON!");
            }
        }

        public override void TurnOff()
        {
            if (IsSmartAlarmOn == true)
            {
                IsSmartAlarmOn = false;
                Console.WriteLine("Turning off the smart alarm...");
                Console.WriteLine("Smart alarm is now OFF!");
            }
            else
            {
                Console.WriteLine("Smart alarm is already OFF!");
            }
        }

        public override bool GetStatus()
        {
            string smartAlarmStatus = IsSmartAlarmOn ? "ON" : "OFF";
            Console.WriteLine("Checking smart alarm status...");
            Console.WriteLine($"Current smart alarm status: {smartAlarmStatus}");
            return IsSmartAlarmOn;
        }
    }
}