using System;

namespace SmartHomeApp
{
    internal class SmartTV : SmartHome
    {
        private bool isSmartTVOn = false;
        private int requiredElectricity = 50;

        public SmartTV(bool isSmartTVOn)
        {
            IsSmartTVOn = isSmartTVOn;
        }

        public SmartTV()
        {
        }

        public bool IsSmartTVOn { get => isSmartTVOn; set => isSmartTVOn = value; }
        public int RequiredElectricity { get => requiredElectricity; }

        public override void TurnOn()
        {
            if (IsSmartTVOn == true)
            {
                Console.WriteLine("Smart TV is already ON!");
            }
            else
            {
                IsSmartTVOn = true;
                ElectricityConsumption += RequiredElectricity;
                Console.WriteLine("Smart TV is now ON!");
            }
        }

        public override void TurnOff()
        {
            if (IsSmartTVOn == false)
            {
                Console.WriteLine("Smart TV is already OFF!");
            }
            else
            {
                IsSmartTVOn = false;
                ElectricityConsumption -= RequiredElectricity;
                Console.WriteLine("Smart TV is now OFF!");
            }
        }

        public override bool GetStatus()
        {
            string smartTVStatus = isSmartTVOn ? "ON" : "OFF";
            Console.WriteLine($"Current smart TV status: {smartTVStatus}");
            return IsSmartTVOn;
        }
    }
}