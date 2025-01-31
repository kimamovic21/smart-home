using System;

namespace SmartHomeApp
{
    internal class SmartTV
    {
        private bool isSmartTVOn;

        public void TurnOnSmartTV()
        {
            isSmartTVOn = true;
            Console.WriteLine("\nTurning on the smart TV...");
            Console.WriteLine("Smart TV is now ON!");
        }

        public void TurnOffSmartTV()
        {
            isSmartTVOn = false;
            Console.WriteLine("\nTurning off the smart TV...");
            Console.WriteLine("Smart TV is now OFF!");
        }

        public void GetSmartTVStatus()
        {
            string smartTVStatus = isSmartTVOn ? "ON" : "OFF";
            Console.WriteLine("\nChecking smart TV status...");
            Console.WriteLine($"Current smart TV status: {smartTVStatus}");
        }
    }
}