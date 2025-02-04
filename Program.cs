﻿using System;

namespace SmartHomeApp
{
    class Program
    {
        static void Main()
        {
            SmartAlarm smartAlarm = new SmartAlarm();
            SmartTV smartTV = new SmartTV();
            SmartAirConditioner smartAirConditioner= new SmartAirConditioner();
            SmartDoorLock smartDoorLock = new SmartDoorLock();
            SmartLight smartLight = new SmartLight();
            SmartWaterHeater smartWaterHeater = new SmartWaterHeater();

            Console.WriteLine("Smart alarm id is: " + smartAlarm.SmartDeviceId);
            Console.WriteLine("Smart TV id is: " + smartTV.SmartDeviceId);
            Console.WriteLine("Smart air conditioner id is: " + smartAirConditioner.SmartDeviceId);
            Console.WriteLine("Smart door lock id is: " + smartDoorLock.SmartDeviceId);
            Console.WriteLine("Smart light id is: " + smartLight.SmartDeviceId);
            Console.WriteLine("Smart water heater id is: " + smartWaterHeater.SmartDeviceId);

            while (true)
            {
                int electricityConsumptionBySmartHome =
                    smartAlarm.GetElectricityConsumption() +
                    smartTV.GetElectricityConsumption() +
                    smartAirConditioner.GetElectricityConsumption() +
                    smartDoorLock.GetElectricityConsumption() +
                    smartLight.GetElectricityConsumption() +
                    smartWaterHeater.GetElectricityConsumption();

                Console.WriteLine("\nWelcome to the Smart Home App!");
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Change status of the smart alarm");
                Console.WriteLine("2. Change status of the smart TV");
                Console.WriteLine("3. Change status of the smart air conditioner");
                Console.WriteLine("4. Change status of the smart door lock");
                Console.WriteLine("5. Change status of the smart light");
                Console.WriteLine("6. Change status of the smart water heater");
                Console.WriteLine("7. Exit");
                Console.WriteLine("\nTotal electricity consumption is: " + electricityConsumptionBySmartHome + "kWh");

                if (electricityConsumptionBySmartHome > 300)
                {
                    Console.WriteLine("Warning! Electricity consumption is above 300kWh");
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
                    Console.WriteLine("1. Turn on the smart air conditioner");
                    Console.WriteLine("2. Turn off the smart air conditioner");
                    Console.WriteLine("3. Set the temperature of the smart air conditioner");
                    string? airConditionerInput = Console.ReadLine();
                    if (airConditionerInput == "1") smartAirConditioner.TurnOn();
                    else if (airConditionerInput == "2") smartAirConditioner.TurnOff();
                    else if (airConditionerInput == "3")
                    {
                        Console.WriteLine("Enter the desired temperature (0 - 30°C)");
                        string? temperatureInput = Console.ReadLine();
                        if (int.TryParse(temperatureInput, out int temperature))
                        {
                            smartAirConditioner.SetTemperature(temperature);
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
                    Console.WriteLine("Choose an option");
                    Console.WriteLine("1. Turn on the smart light");
                    Console.WriteLine("2. Turn off the smart light");
                    Console.WriteLine("3. Set the brightness of the smart light");

                    string? lightInput = Console.ReadLine();

                    if (lightInput == "1")
                    {
                        smartLight.TurnOn();
                    }
                    else if (lightInput == "2")
                    {
                        smartLight.TurnOff();
                    }
                    else if (lightInput == "3")
                    {
                        Console.WriteLine("Enter the desired brightness (1-100):");
                        string? brightnessInput = Console.ReadLine();
                        if (int.TryParse(brightnessInput, out int brightness))
                        {
                            smartLight.BrightnessLevel = brightness;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (userInput == "6") 
                {
                    Console.WriteLine("Choose an option");
                    Console.WriteLine("1. Turn on the smart water heater");
                    Console.WriteLine("2. Turn off the smart water heater");
                    Console.WriteLine("3. Set the temperature of the smart water heater");

                    string? waterHeaterInput = Console.ReadLine();

                    if (waterHeaterInput == "1")
                    {
                        smartWaterHeater.TurnOn();
                    }
                    else if (waterHeaterInput == "2")
                    {
                        smartWaterHeater.TurnOff();
                    }
                    else if (waterHeaterInput == "3")
                    {
                        Console.WriteLine("Enter the desired temperature (20-50°C):");
                        string? temperatureInput = Console.ReadLine();
                        if (int.TryParse(temperatureInput, out int temperature))
                        {
                            smartWaterHeater.SetTemperature(temperature);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                else if (userInput == "7")
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