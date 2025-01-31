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
            SmartHeating smartHeating = new SmartHeating();

            smartHome.WelcomeMessage();

            smartAlarm.TurnOffSmartAlarm();
            smartAlarm.GetSmartAlarmStatus();

            smartHeating.TurnOnSmartHeating();
            smartHeating.SetTemperature(25);
            smartHeating.GetSmartHeatingStatus();

            smartTV.TurnOnSmartTV();
            smartTV.GetSmartTVStatus();

            smartAlarm.TurnOnSmartAlarm();
            smartAlarm.GetSmartAlarmStatus();

            smartTV.TurnOffSmartTV();
            smartTV.GetSmartTVStatus();

            smartHeating.TurnOffSmartHeating();
            smartHeating.SetTemperature(0);
            smartHeating.GetSmartHeatingStatus();
        }
    }
}