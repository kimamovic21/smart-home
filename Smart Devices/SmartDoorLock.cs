using System;

namespace SmartHomeApp
{
    class SmartDoorLock : SmartHome
    {
        private bool isLocked = true;
        private string pinCode = "123456";
        private int requiredElectricity = 10;
        public int RequiredElectricity { get => requiredElectricity; }

        public bool IsLocked { get => isLocked; }
        public string PinCode { get => pinCode; }

        public override void TurnOn()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Smart door lock is now active.");
            Console.ResetColor();
        }

        public override void TurnOff()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Smart door lock is now inactive.");
            Console.ResetColor();
        }

        public override bool GetStatus()
        {
            string lockStatus = isLocked ? "locked" : "unlocked";
            Console.ForegroundColor = isLocked ? ConsoleColor.Red : ConsoleColor.Green;

            Console.WriteLine($"The door is currently {lockStatus}.");
            Console.ResetColor();

            return isLocked;
        }


        public void LockDoor()
        {
            if (!isLocked)
            {
                isLocked = true;
                ElectricityConsumption += requiredElectricity;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Door is now locked.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Door is already locked.");
            }
            Console.ResetColor();
        }

        public void UnlockDoor(string enteredPin)
        {
            if (enteredPin == pinCode)
            {
                if (isLocked)
                {
                    isLocked = false;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Door is now unlocked.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Door is already unlocked.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect PIN! Door remains locked.");
            }
            Console.ResetColor();
        }

        public void ChangePinCode(string oldPin, string newPin)
        {
            if (oldPin == pinCode)
            {
                if (string.IsNullOrWhiteSpace(newPin) || newPin.Length < 6 || newPin.Length > 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("New PIN must be between 6 and 15 characters long and cannot be empty.");
                }
                else
                {
                    pinCode = newPin;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PIN code has been changed successfully.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect old PIN! Unable to change PIN.");
            }
            Console.ResetColor();
        }
    }
}