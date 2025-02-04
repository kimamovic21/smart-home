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
                Console.WriteLine("Smart alarm is already ON!");
            }
            else
            {
                isSmartAlarmOn = true;
                ElectricityConsumption += requiredElectricity;
                Console.WriteLine("Smart alarm is now ON!");
            }
        }

        public override void TurnOff()
        {
            if (isSmartAlarmOn)
            {
                isSmartAlarmOn = false;
                ElectricityConsumption -= requiredElectricity;  
                Console.WriteLine("Smart alarm is now OFF!");
            }
            else
            {
                Console.WriteLine("Smart alarm is already OFF!");
            }
        }


        public override bool GetStatus()
        {
            string smartAlarmStatus = isSmartAlarmOn ? "ON" : "OFF";
            Console.WriteLine($"Current smart alarm status: {smartAlarmStatus}");
            return isSmartAlarmOn;
        }
    }
}