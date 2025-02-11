using System;

namespace SmartHomeApp
{
    internal class SmartTV : SmartHome
    {
        private bool isSmartTVOn = false;
        private int requiredElectricity = 50;
        private string currentChannel = string.Empty;
        private int volume = 50; 
        private static readonly string[] channels = { "Sport", "News", "Science", "Movies", "Cooking" };

        public SmartTV(bool isSmartTVOn)
        {
            IsSmartTVOn = isSmartTVOn;
        }

        public SmartTV() { }

        public bool IsSmartTVOn { get => isSmartTVOn; set => isSmartTVOn = value; }
        public int RequiredElectricity { get => requiredElectricity; }
        public int Volume { get => volume; }

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
            Console.WriteLine($"Current channel: {(string.IsNullOrEmpty(currentChannel) ? "None" : currentChannel)}");
            Console.WriteLine($"Current volume: {volume} %"); 
            Console.ResetColor();
            return IsSmartTVOn;
        }

        public void ChangeChannel()
        {
            if (!IsSmartTVOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The TV is OFF. Please turn it on to change channels.");
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

        public void SetVolume()
        {
            if (!IsSmartTVOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The TV is OFF. Please turn it ON to adjust the volume.");
                Console.ResetColor();
                return;
            }

            Console.Write("Enter new volume level (1-100): ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int newVolume) && newVolume >= 1 && newVolume <= 100)
            {
                volume = newVolume;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Volume set to {volume}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid volume level. Please enter a value between 1 and 100.");
            }
            Console.ResetColor();
        }
    }
}