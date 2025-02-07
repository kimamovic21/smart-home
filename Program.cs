using System;

namespace SmartHomeApp
{
    class Program
    {
        static void Main()
        {
            SmartAlarm smartAlarm = new SmartAlarm();
            SmartTV smartTV = new SmartTV();
            SmartAirConditioner smartAirConditioner = new SmartAirConditioner();
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
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Change status of the smart alarm");
                Console.WriteLine("2. Change status of the smart TV");
                Console.WriteLine("3. Change status of the smart air conditioner");
                Console.WriteLine("4. Change status of the smart door lock");
                Console.WriteLine("5. Change status of the smart light");
                Console.WriteLine("6. Change status of the smart water heater");
                Console.WriteLine("7. Exit");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nTotal electricity consumption is: " + electricityConsumptionBySmartHome + " kWh");
                Console.ResetColor();

                if (electricityConsumptionBySmartHome > 300)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warning! Electricity consumption is above 300 kWh");
                    Console.ResetColor();
                }

                string? userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("\nChoose an option");
                        Console.WriteLine("1. Turn on the smart alarm");
                        Console.WriteLine("2. Turn off the smart alarm");
                        Console.WriteLine("3. Check the smart alarm status");

                        string? alarmInput = Console.ReadLine();

                        if (alarmInput == "1")
                        {
                            smartAlarm.TurnOn();
                        }
                        else if (alarmInput == "2")
                        {
                            smartAlarm.TurnOff();
                        }
                        else if (alarmInput == "3")
                        {
                            smartAlarm.GetStatus();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input.");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\nReturn to the main menu? (y/n)");
                        string? returnToMainMenu = Console.ReadLine();
                        if (returnToMainMenu?.ToLower() == "y")
                        {
                            break;
                        }
                    }
                }

                else if (userInput == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("\nChoose an option");
                        Console.WriteLine("1. Turn on the smart TV");
                        Console.WriteLine("2. Turn off the smart TV");
                        Console.WriteLine("3. Change the TV channel");
                        Console.WriteLine("4. Check the smart TV status");

                        string? tvInput = Console.ReadLine();

                        if (tvInput == "1")
                        {
                            smartTV.TurnOn();
                        }
                        else if (tvInput == "2")
                        {
                            smartTV.TurnOff();
                        }
                        else if (tvInput == "3")
                        {
                            smartTV.ChangeChannel();
                        }
                        else if (tvInput == "4")
                        {
                            smartTV.GetStatus();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input.");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\nReturn to the main menu? (y/n)");
                        string? returnToMainMenu = Console.ReadLine();
                        if (returnToMainMenu?.ToLower() == "y")
                        {
                            break;
                        }
                    }
                }

                else if (userInput == "3")
                {
                    while (true)
                    {
                        Console.WriteLine("\nChoose an option:");
                        Console.WriteLine("1. Turn on the smart air conditioner");
                        Console.WriteLine("2. Turn off the smart air conditioner");
                        Console.WriteLine("3. Set the temperature of the smart air conditioner");
                        Console.WriteLine("4. Check the smart air conditioner status");

                        string? airConditionerInput = Console.ReadLine();
                        if (airConditionerInput == "1")
                        {
                            smartAirConditioner.TurnOn();
                        }
                        else if (airConditionerInput == "2")
                        {
                            smartAirConditioner.TurnOff();
                        }
                        else if (airConditionerInput == "3")
                        {
                            if (!smartAirConditioner.IsSmartAirConditionerOn)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The smart air conditioner is off. Please turn it on to set the temperature.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Enter the desired temperature (0 - 30°C):");
                                string? temperatureInput = Console.ReadLine();
                                if (int.TryParse(temperatureInput, out int temperature) && temperature >= 0 && temperature <= 30)
                                {
                                    smartAirConditioner.SetTemperature(temperature);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid temperature. Please enter a number between 0 and 30.");
                                    Console.ResetColor();
                                }
                            }
                        }
                        else if (airConditionerInput == "4")
                        {
                            smartAirConditioner.GetStatus();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input.");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\nReturn to the main menu? (y/n)");
                        string? returnToMainMenu = Console.ReadLine();
                        if (returnToMainMenu?.ToLower() == "y")
                        {
                            break;
                        }
                    }
                }

                else if (userInput == "4")
                {
                    while (true)
                    {
                        Console.WriteLine("\nChoose an option");
                        Console.WriteLine("1. Lock the door");
                        Console.WriteLine("2. Unlock the door");
                        Console.WriteLine("3. Change PIN code");
                        Console.WriteLine("4. Check the smart lock door status");

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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input.");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\nReturn to the main menu? (y/n)");
                        string? returnToMainMenu = Console.ReadLine();
                        if (returnToMainMenu?.ToLower() == "y")
                        {
                            break;
                        }
                    }
                }

                else if (userInput == "5")
                {
                    while (true)
                    {
                        Console.WriteLine("\nChoose an option");
                        Console.WriteLine("1. Turn on the smart light");
                        Console.WriteLine("2. Turn off the smart light");
                        Console.WriteLine("3. Set the brightness of the smart light");
                        Console.WriteLine("4. Check the smart light status");

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
                            if (!smartLight.IsSmartLightOn) 
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The smart light is off. Please turn it on to set the brightness.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Enter the desired brightness (1-100):");
                                string? brightnessInput = Console.ReadLine();
                                if (int.TryParse(brightnessInput, out int brightness) && brightness >= 1 && brightness <= 100)
                                {
                                    smartLight.BrightnessLevel = brightness; 
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid brightness value. Please enter a number between 1 and 100.");
                                    Console.ResetColor();
                                }
                            }
                        }
                        else if (lightInput == "4")
                        {
                            smartLight.GetStatus();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input.");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\nReturn to the main menu? (y/n)");
                        string? returnToMainMenu = Console.ReadLine();
                        if (returnToMainMenu?.ToLower() == "y")
                        {
                            break;
                        }
                    }
                }

                else if (userInput == "6")
                {
                    while (true)
                    {
                        Console.WriteLine("\nChoose an option");
                        Console.WriteLine("1. Turn on the smart water heater");
                        Console.WriteLine("2. Turn off the smart water heater");
                        Console.WriteLine("3. Set the temperature of the smart water heater");
                        Console.WriteLine("4. Check the smart water heater status");

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
                            if (!smartWaterHeater.IsSmartWaterHeaterOn)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The smart water heater is off. Please turn it on to set the temperature.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Enter the desired temperature (20-50°C):");
                                string? temperatureInput = Console.ReadLine();
                                if (int.TryParse(temperatureInput, out int temperature) && temperature >= 20 && temperature <= 50)
                                {
                                    smartWaterHeater.SetTemperature(temperature);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid temperature. Please enter a number between 20 and 50.");
                                    Console.ResetColor();
                                }
                            }
                        }
                        else if (waterHeaterInput == "4")
                        {
                            smartWaterHeater.GetStatus();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input.");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\nReturn to the main menu? (y/n)");
                        string? returnToMainMenu = Console.ReadLine();
                        if (returnToMainMenu?.ToLower() == "y")
                        {
                            break;
                        }
                    }
                }


                else if (userInput == "7")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input.");
                    Console.ResetColor();
                }
            }
        }
    }
}