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

        public SmartTV() { }

        public bool IsSmartTVOn { get => isSmartTVOn; set => isSmartTVOn = value; }
        public int RequiredElectricity { get => requiredElectricity; }

        public override void TurnOn()
        {
            if (IsSmartTVOn)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart TV is already ON!");
            }
            else
            {
                IsSmartTVOn = true;
                ElectricityConsumption += RequiredElectricity;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smart TV is now ON!");
            }
            Console.ResetColor();
        }

        public override void TurnOff()
        {
            if (!IsSmartTVOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart TV is already OFF!");
            }
            else
            {
                IsSmartTVOn = false;
                ElectricityConsumption -= RequiredElectricity;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smart TV is now OFF!");
            }
            Console.ResetColor();
        }

        public override bool GetStatus()
        {
            Console.ForegroundColor = IsSmartTVOn ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Current Smart TV status: {(IsSmartTVOn ? "ON" : "OFF")}");
            Console.ResetColor();
            return IsSmartTVOn;
        }


        public void ChangeChannel()
        {
            if (!IsSmartTVOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The TV is off. Please turn it on to change channels.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSelect a channel:");
            for (int i = 0; i < channels.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {channels[i]}");
            }
            Console.ResetColor();

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= channels.Length)
            {
                currentChannel = channels[choice - 1];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You are now watching {currentChannel} channel.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please choose a valid channel.");
            }
            Console.ResetColor();
        }
    }
}