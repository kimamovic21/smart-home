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
            Console.WriteLine("Smart door lock is now active.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Smart door lock is now inactive.");
        }

        public override bool GetStatus()
        {
            string lockStatus = isLocked ? "locked" : "unlocked";
            Console.WriteLine($"The door is currently {lockStatus}.");
            return isLocked;
        }

        public void LockDoor()
        {
            if (!isLocked)
            {
                isLocked = true;
                ElectricityConsumption += requiredElectricity;
                Console.WriteLine("Door is now locked.");
            }
            else
            {
                Console.WriteLine("Door is already locked.");
            }
        }

        public void UnlockDoor(string enteredPin)
        {
            if (enteredPin == pinCode)
            {
                if (isLocked)
                {
                    isLocked = false;
                    Console.WriteLine("Door is now unlocked.");
                }
                else
                {
                    Console.WriteLine("Door is already unlocked.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect PIN! Door remains locked.");
            }
        }

        public void ChangePinCode(string oldPin, string newPin)
        {
            if (oldPin == pinCode)
            {
                if (string.IsNullOrWhiteSpace(newPin) || newPin.Length < 6 || newPin.Length > 15)
                {
                    Console.WriteLine("New PIN must be between 6 and 15 characters long and cannot be empty.");
                }
                else
                {
                    pinCode = newPin;
                    Console.WriteLine("PIN code has been changed successfully.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect old PIN! Unable to change PIN.");
            }
        }

    }
}