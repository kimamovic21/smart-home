using System;

namespace SmartHomeApp
{
    class Program
    {
        static void Main()
        {
            List<SmartHome> smartDevices = new List<SmartHome>
                {
                    new SmartAlarm(),
                    new SmartTV(),
                    new SmartAirConditioner(),
                    new SmartDoorLock(),
                    new SmartLight(),
                    new SmartWaterHeater(),
                    new SmartSurveillanceCameras()
                };

            foreach (var device in smartDevices)
            {
                Console.WriteLine($"Smart device id is: {device.SmartDeviceId}");
            }

            while (true)
            {
                int electricityConsumptionBySmartHome = 0;
                foreach (var device in smartDevices)
                {
                    electricityConsumptionBySmartHome += device.GetElectricityConsumption();
                }

                Console.WriteLine("\nWelcome to the Smart Home App!");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Change status of the smart alarm");
                Console.WriteLine("2. Change status of the smart TV");
                Console.WriteLine("3. Change status of the smart air conditioner");
                Console.WriteLine("4. Change status of the smart door lock");
                Console.WriteLine("5. Change status of the smart light");
                Console.WriteLine("6. Change status of the smart water heater");
                Console.WriteLine("7. Change status of the smart surveillance cameras");
                Console.WriteLine("8. Exit");

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
                    HandleSmartAlarm((SmartAlarm)smartDevices[0]);
                else if (userInput == "2")
                    HandleSmartTV((SmartTV)smartDevices[1]);
                else if (userInput == "3")
                    HandleSmartAirConditioner((SmartAirConditioner)smartDevices[2]);
                else if (userInput == "4")
                    HandleSmartDoorLock((SmartDoorLock)smartDevices[3]);
                else if (userInput == "5")
                    HandleSmartLight((SmartLight)smartDevices[4]);
                else if (userInput == "6")
                    HandleSmartWaterHeater((SmartWaterHeater)smartDevices[5]);
                else if (userInput == "7")
                    HandleSmartSurveillanceCameras((SmartSurveillanceCameras)smartDevices[6]);
                else if (userInput == "8")
                    break;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input.");
                    Console.ResetColor();
                }
            }
        }

        static void HandleSmartAlarm(SmartAlarm smartAlarm)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Turn on the smart alarm");
                Console.WriteLine("2. Turn off the smart alarm");
                Console.WriteLine("3. Set the smart alarm decibel level");
                Console.WriteLine("4. Check the smart alarm status");

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
                    if (!smartAlarm.IsSmartAlarmOn)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The smart alarm is off. Please turn it on to set the decibel level.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("Enter decibel level (80-120): ");
                        if (int.TryParse(Console.ReadLine(), out int decibelLevel))
                        {
                            smartAlarm.SetDecibelLevel(decibelLevel);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            Console.ResetColor();
                        }
                    }
                }
                else if (alarmInput == "4")
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

        static void HandleSmartTV(SmartTV smartTV)
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

        static void HandleSmartAirConditioner(SmartAirConditioner smartAirConditioner)
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

        static void HandleSmartDoorLock(SmartDoorLock smartDoorLock)
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
                    if (enteredPin != null)
                    {
                        smartDoorLock.UnlockDoor(enteredPin);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("PIN cannot be null.");
                        Console.ResetColor();
                    }
                }
                else if (doorInput == "3")
                {
                    Console.Write("Enter old PIN: ");
                    string? oldPin = Console.ReadLine();
                    Console.Write("Enter new PIN: ");
                    string? newPin = Console.ReadLine();
                    if (oldPin != null && newPin != null)
                    {
                        smartDoorLock.ChangePinCode(oldPin, newPin);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("PINs cannot be null.");
                        Console.ResetColor();
                    }
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

        static void HandleSmartLight(SmartLight smartLight)
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

        static void HandleSmartWaterHeater(SmartWaterHeater smartWaterHeater)
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

        static void HandleSmartSurveillanceCameras(SmartSurveillanceCameras smartCameras)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Turn on surveillance cameras");
                Console.WriteLine("2. Turn off surveillance cameras");
                Console.WriteLine("3. Set camera resolution");
                Console.WriteLine("4. Check surveillance cameras status");

                string? cameraInput = Console.ReadLine();

                if (cameraInput == "1")
                {
                    smartCameras.TurnOn();
                }
                else if (cameraInput == "2")
                {
                    smartCameras.TurnOff();
                }
                else if (cameraInput == "3")
                {
                    if (!smartCameras.IsCamerasOn)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The smart surveillance cameras are off. Please turn them on to set the camera resolution.");
                        Console.ResetColor();
                        continue;
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choose camera resolution:");
                    Console.WriteLine("1. Low");
                    Console.WriteLine("2. Medium");
                    Console.WriteLine("3. High");
                    Console.ResetColor();

                    if (int.TryParse(Console.ReadLine(), out int resolutionChoice))
                    {
                        switch (resolutionChoice)
                        {
                            case 1:
                                smartCameras.SetCameraResolution(SmartSurveillanceCameras.CameraResolution.Low);
                                break;
                            case 2:
                                smartCameras.SetCameraResolution(SmartSurveillanceCameras.CameraResolution.Medium);
                                break;
                            case 3:
                                smartCameras.SetCameraResolution(SmartSurveillanceCameras.CameraResolution.High);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid input. Please choose a valid camera resolution.");
                                Console.ResetColor();
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter a number.");
                        Console.ResetColor();
                    }
                }
                else if (cameraInput == "4")
                {
                    smartCameras.GetStatus();
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
    }
}