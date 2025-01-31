using System;

namespace SmartHomeApp
{
    class Program
    {
        static void Main()
        {
            SmartAlarm smartAlarm = new SmartAlarm();
            SmartTV smartTV = new SmartTV();
            SmartHeating smartHeating = new SmartHeating();

            Console.WriteLine("Welcome to the Smart Home App!");

            smartAlarm.TurnOff();
            smartAlarm.GetStatus();

            smartHeating.TurnOn();
            smartHeating.SetTemperature(25);
            smartHeating.GetStatus();

            smartTV.TurnOn();
            smartTV.GetStatus();

            smartAlarm.TurnOn();
            smartAlarm.GetStatus();

            smartTV.TurnOff();
            smartTV.GetStatus();

            smartHeating.TurnOff();
            smartHeating.SetTemperature(0);
            smartHeating.GetStatus();
        }
    }
}