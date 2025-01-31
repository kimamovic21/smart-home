using System;

namespace SmartHomeApp
{
    class Program
    {
        static void Main()
        {
            SmartHome smartHome = new SmartHome();
            smartHome.WelcomeMessage();

            SmartAlarm alarm = new SmartAlarm();

            Console.WriteLine("\nTurning on the alarm...");
            alarm.TurnOnAlarm();

            Console.WriteLine("\nChecking alarm status...");
            alarm.GetAlarmStatus();

            Console.WriteLine("\nTurning off the alarm...");
            alarm.TurnOffAlarm();

            Console.WriteLine("\nChecking alarm status again...");
            alarm.GetAlarmStatus();
        }
    }
}