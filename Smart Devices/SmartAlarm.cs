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
            IsSmartAlarmOn = true;
            Console.WriteLine("\nTurning on the smart alarm...");
            Console.WriteLine("Smart alarm is now ON!");
        }

        public override void TurnOff()
        {
            IsSmartAlarmOn = false;
            Console.WriteLine("\nTurning off the smart alarm...");
            Console.WriteLine("Smart alarm is now OFF!");
        }

        public override void GetStatus()
        {
            string smartAlarmStatus = IsSmartAlarmOn ? "ON" : "OFF";
            Console.WriteLine("\nChecking smart alarm status...");
            Console.WriteLine($"Current smart alarm status: {smartAlarmStatus}");
        }
    }
}