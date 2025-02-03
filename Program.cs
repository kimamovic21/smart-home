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
            SmartDoorLock smartDoorLock = new SmartDoorLock(); 

            Console.WriteLine("Smart alarm id is: " + smartAlarm.SmartDeviceId);
            Console.WriteLine("Smart TV id is: " + smartTV.SmartDeviceId);
            Console.WriteLine("Smart heating id is: " + smartHeating.SmartDeviceId);
            Console.WriteLine("Smart door lock id is: " + smartDoorLock.SmartDeviceId);

            while (true)
            {
                int electricityConsumptionBySmartHome = smartHeating.GetElectricityConsumption();
                Console.WriteLine("\nWelcome to the Smart Home App!");
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Change status of smart alarm");
                Console.WriteLine("2. Change status of the smart TV");
                Console.WriteLine("3. Change status of the smart heating");
                Console.WriteLine("4. Change status of the smart door lock"); 
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nTotal electricity consumption is: " + electricityConsumptionBySmartHome + "kWh");

                if (electricityConsumptionBySmartHome > 150)
                {
                    Console.WriteLine("Warning! Electricity consumption is above 150kWh");
                }

                string? userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Choose an option");
                    Console.WriteLine("1. Turn on the smart alarm");
                    Console.WriteLine("2. Turn off the smart alarm");
                    string? alarmInput = Console.ReadLine();
                    if (alarmInput == "1") smartAlarm.TurnOn();
                    else if (alarmInput == "2") smartAlarm.TurnOff();
                    else Console.WriteLine("Invalid input");
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Choose an option");
                    Console.WriteLine("1. Turn on the smart TV");
                    Console.WriteLine("2. Turn off the smart TV");
                    string? tvInput = Console.ReadLine();
                    if (tvInput == "1") smartTV.TurnOn();
                    else if (tvInput == "2") smartTV.TurnOff();
                    else Console.WriteLine("Invalid input");
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Choose an option");
                    Console.WriteLine("1. Turn on the smart heating");
                    Console.WriteLine("2. Turn off the smart heating");
                    Console.WriteLine("3. Set the temperature of the smart heating");
                    string? heatingInput = Console.ReadLine();
                    if (heatingInput == "1") smartHeating.TurnOn();
                    else if (heatingInput == "2") smartHeating.TurnOff();
                    else if (heatingInput == "3")
                    {
                        Console.WriteLine("Enter the desired temperature (0 - 30°C)");
                        string? temperatureInput = Console.ReadLine();
                        if (int.TryParse(temperatureInput, out int temperature))
                        {
                            smartHeating.SetTemperature(temperature);
                        }
                        else Console.WriteLine("Invalid input");
                    }
                    else Console.WriteLine("Invalid input");
                }
                else if (userInput == "4") 
                {
                    Console.WriteLine("Choose an option");
                    Console.WriteLine("1. Lock the door");
                    Console.WriteLine("2. Unlock the door");
                    Console.WriteLine("3. Change PIN code");
                    Console.WriteLine("4. Check lock status");

                    string? doorInput = Console.ReadLine();

                    if (doorInput == "1")
                    {
                        smartDoorLock.LockDoor();
                    }
                    else if (doorInput == "2")
                    {
                        Console.Write("Enter PIN to unlock: ");
                        string? enteredPin = Console.ReadLine();
                        smartDoorLock.UnlockDoor(enteredPin);
                    }
                    else if (doorInput == "3")
                    {
                        Console.Write("Enter old PIN: ");
                        string? oldPin = Console.ReadLine();
                        Console.Write("Enter new PIN: ");
                        string? newPin = Console.ReadLine();
                        smartDoorLock.ChangePinCode(oldPin, newPin);
                    }
                    else if (doorInput == "4")
                    {
                        smartDoorLock.GetStatus();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (userInput == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}