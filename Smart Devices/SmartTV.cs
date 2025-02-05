using System;

namespace SmartHomeApp
{
    internal class SmartTV : SmartHome
    {
        private bool isSmartTVOn = false;
        private int requiredElectricity = 50;
        private string currentChannel = string.Empty;
        private static readonly string[] channels = { "Sport", "News", "Science", "Movies", "Cooking" };

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

        public void ChangeChannel()
        {
            if (!IsSmartTVOn)
            {
                Console.WriteLine("The TV is off. Please turn it on to change channels.");
                return;
            }

            Console.WriteLine("\nSelect a channel:");
            for (int i = 0; i < channels.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {channels[i]}");
            }

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= channels.Length)
            {
                currentChannel = channels[choice - 1];
                Console.WriteLine($"You are now watching {currentChannel} channel.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a valid channel.");
            }
        }
    }
}