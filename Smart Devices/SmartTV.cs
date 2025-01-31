using System;

namespace SmartHomeApp
{
    internal class SmartTV : SmartHome
    {
        private bool isSmartTVOn = false;

        public SmartTV(bool isSmartTVOn)
        {
            IsSmartTVOn = isSmartTVOn;
        }

        public SmartTV()
        {
        }

        public bool IsSmartTVOn { get => isSmartTVOn; set => isSmartTVOn = value; }

        public override void TurnOn()
        {
            IsSmartTVOn = true;
            Console.WriteLine("\nTurning on the smart TV...");
            Console.WriteLine("Smart TV is now ON!");
        }

        public override void TurnOff()
        {
            IsSmartTVOn = false;
            Console.WriteLine("\nTurning off the smart TV...");
            Console.WriteLine("Smart TV is now OFF!");
        }

        public override void GetStatus()
        {
            string smartTVStatus = isSmartTVOn ? "ON" : "OFF";
            Console.WriteLine("\nChecking smart TV status...");
            Console.WriteLine($"Current smart TV status: {smartTVStatus}");
        }
    }
}