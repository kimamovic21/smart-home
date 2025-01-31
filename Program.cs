using System;

namespace SmartHomeApp
{
    class Program
    {
        static void Main()
        {
            SmartHome smartHome = new SmartHome();
            SmartAlarm smartAlarm = new SmartAlarm();
            SmartTV smartTV = new SmartTV();

            smartHome.WelcomeMessage();

            smartAlarm.TurnOffSmartAlarm();
            smartAlarm.GetSmartAlarmStatus();

            smartTV.TurnOnSmartTV();
            smartTV.GetSmartTVStatus();

            smartAlarm.TurnOnSmartAlarm();
            smartAlarm.GetSmartAlarmStatus();

            smartTV.TurnOffSmartTV();
            smartTV.GetSmartTVStatus();
        }
    }
}