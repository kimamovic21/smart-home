using System;

namespace SmartHomeApp
{
    internal class SmartSurveillanceCameras : SmartHome
    {
        private bool isCamerasOn = false;
        private const int requiredElectricity = 50;
        private CameraResolution resolution = CameraResolution.Medium; 

        public enum CameraResolution
        {
            Low,
            Medium,
            High
        }

        public bool IsCamerasOn { get => isCamerasOn; set => isCamerasOn = value; }
        public int RequiredElectricity { get => requiredElectricity; }
        public CameraResolution Resolution { get => resolution; }

        public override void TurnOn()
        {
            if (isCamerasOn)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Surveillance cameras are already ON!");
            }
            else
            {
                isCamerasOn = true;
                ElectricityConsumption += requiredElectricity;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Surveillance cameras are now ON!");
            }
            Console.ResetColor();
        }

        public override void TurnOff()
        {
            if (isCamerasOn)
            {
                isCamerasOn = false;
                ElectricityConsumption -= requiredElectricity;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Surveillance cameras are now OFF!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Surveillance cameras are already OFF!");
            }
            Console.ResetColor();
        }

        public override bool GetStatus()
        {
            string cameraStatus = isCamerasOn ? "ON" : "OFF";

            Console.ForegroundColor = isCamerasOn ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Current surveillance cameras status: {cameraStatus}");
            Console.WriteLine($"Current camera resolution: {resolution}");
            Console.ResetColor();

            return isCamerasOn;
        }

        public void SetCameraResolution(CameraResolution newResolution)
        {
            if (!isCamerasOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The smart surveillance cameras are off. Please turn them on to set the camera resolution.");
                Console.ResetColor();
                return;
            }

            resolution = newResolution;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Camera resolution set to {resolution}");
            Console.ResetColor();
        }
    }
}