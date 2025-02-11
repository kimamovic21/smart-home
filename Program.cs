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
                string deviceName = device.GetType().Name.Replace("Smart", "");
                Console.WriteLine($"Smart device name: {deviceName}. Smart device id: {device.SmartDeviceId}");
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

                switch (userInput)
                {
                    case "1":
                        HandleSmartAlarm((SmartAlarm)smartDevices[0]);
                        break;
                    case "2":
                        HandleSmartTV((SmartTV)smartDevices[1]);
                        break;
                    case "3":
                        HandleSmartAirConditioner((SmartAirConditioner)smartDevices[2]);
                        break;
                    case "4":
                        HandleSmartDoorLock((SmartDoorLock)smartDevices[3]);
                        break;
                    case "5":
                        HandleSmartLight((SmartLight)smartDevices[4]);
                        break;
                    case "6":
                        HandleSmartWaterHeater((SmartWaterHeater)smartDevices[5]);
                        break;
                    case "7":
                        HandleSmartSurveillanceCameras((SmartSurveillanceCameras)smartDevices[6]);
                        break;
                    case "8":
                        Console.WriteLine("Exiting the Smart Home App. Goodbye!");
                        return; 
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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

                switch (alarmInput)
                {
                    case "1":
                        smartAlarm.TurnOn();
                        break;

                    case "2":
                        smartAlarm.TurnOff();
                        break;

                    case "3":
                        smartAlarm.SetDecibelLevel();
                        break;

                    case "4":
                        smartAlarm.GetStatus();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Turn on the smart TV");
                Console.WriteLine("2. Turn off the smart TV");
                Console.WriteLine("3. Change the TV channel");
                Console.WriteLine("4. Adjust the TV volume");
                Console.WriteLine("5. Check the smart TV status");

                string? tvInput = Console.ReadLine();

                switch (tvInput)
                {
                    case "1":
                        smartTV.TurnOn();
                        break;
                    case "2":
                        smartTV.TurnOff();
                        break;
                    case "3":
                        smartTV.ChangeChannel();
                        break;
                    case "4":
                        smartTV.SetVolume();
                        break;
                    case "5":
                        smartTV.GetStatus();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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

                switch (airConditionerInput)
                {
                    case "1":
                        smartAirConditioner.TurnOn();
                        break;
                    case "2":
                        smartAirConditioner.TurnOff();
                        break;
                    case "3":
                        smartAirConditioner.SetTemperature();
                        break;
                    case "4":
                        smartAirConditioner.GetStatus();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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

                switch (doorInput)
                {
                    case "1":
                        smartDoorLock.LockDoor();
                        break;
                    case "2":
                        smartDoorLock.UnlockDoor();
                        break;
                    case "3":
                        smartDoorLock.ChangePinCode();
                        break;
                    case "4":
                        smartDoorLock.GetStatus();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Turn on the smart light");
                Console.WriteLine("2. Turn off the smart light");
                Console.WriteLine("3. Set the brightness of the smart light");
                Console.WriteLine("4. Check the smart light status");

                string? lightInput = Console.ReadLine();

                switch (lightInput)
                {
                    case "1":
                        smartLight.TurnOn();
                        break;
                    case "2":
                        smartLight.TurnOff();
                        break;
                    case "3":
                        smartLight.SetBrightnessLevel();
                        break;
                    case "4":
                        smartLight.GetStatus();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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

                switch (waterHeaterInput)
                {
                    case "1":
                        smartWaterHeater.TurnOn();
                        break;
                    case "2":
                        smartWaterHeater.TurnOff();
                        break;
                    case "3":
                        smartWaterHeater.SetTemperature();
                        break;
                    case "4":
                        smartWaterHeater.GetStatus();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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

                switch (cameraInput)
                {
                    case "1":
                        smartCameras.TurnOn();
                        break;
                    case "2":
                        smartCameras.TurnOff();
                        break;
                    case "3":
                        smartCameras.SetCameraResolution();
                        break;
                    case "4":
                        smartCameras.GetStatus();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        break;
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