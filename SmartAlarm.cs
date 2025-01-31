using System;

namespace SmartHomeApp
{
    internal class SmartAlarm
    {
        private bool isSmartAlarmOn;

        public void TurnOnSmartAlarm()
        {
            isSmartAlarmOn = true;
            Console.WriteLine("\nTurning on the smart alarm...");
            Console.WriteLine("Smart alarm is now ON!");
        }

        public void TurnOffSmartAlarm()
        {
            isSmartAlarmOn = false;
            Console.WriteLine("\nTurning off the smart alarm...");
            Console.WriteLine("Smart alarm is now OFF!");
        }

        public void GetSmartAlarmStatus()
        {
            string smartAlarmStatus = isSmartAlarmOn ? "ON" : "OFF";
            Console.WriteLine("\nChecking smart alarm status...");
            Console.WriteLine($"Current smart alarm status: {smartAlarmStatus}");
        }
    }
}