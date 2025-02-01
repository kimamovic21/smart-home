using System;

namespace SmartHomeApp
{
    internal class SmartHeating : SmartHome
    {
        private bool isSmartHeatingOn = false;
        private int temperature = 20; //Default temperature
        private int requiredElectricity = 100;

        public bool IsSmartHeatingOn { get => isSmartHeatingOn; set => isSmartHeatingOn = value; }
        public int Temperature { get => temperature; set => temperature = value; }
        public int RequiredElectricity { get => requiredElectricity; }

        public SmartHeating()
        {
        }

        public SmartHeating(bool isSmartHeatingOn, int temperature)
        {
            IsSmartHeatingOn = isSmartHeatingOn;
            Temperature = temperature;
        }

        public override void TurnOn()
        {
            if (IsSmartHeatingOn == false)
            {
                IsSmartHeatingOn = true;
                ElectricityConsumption += RequiredElectricity;
                Console.WriteLine("Turning on the smart heating...");
                Console.WriteLine("Smart heating is now ON!");
                this.GetStatus();
            }
            else
            {
                Console.WriteLine("Smart heating is already ON!");
            }
        }

        public override void TurnOff()
        {
            if (IsSmartHeatingOn == true)
            {
                IsSmartHeatingOn = false;
                ElectricityConsumption -= RequiredElectricity;
                Console.WriteLine("Turning off the smart heating...");
                Console.WriteLine("Smart heating is now OFF!");
            }
            else
            {
                Console.WriteLine("Smart heating is already OFF!");
            }
        }

        public void SetTemperature(int newTemperature)
        {
            if (newTemperature < 0 || newTemperature > 30)
            {
                Console.WriteLine("Invalid temperature! Please set a value between 0°C and 30°C.");
            }
            else
            {
                Temperature = newTemperature;
                Console.WriteLine($"Setting smart heating temperature to {Temperature}°C...");
            }
        }

        public override bool GetStatus()
        {
            string smartHeatingStatus = IsSmartHeatingOn ? "ON" : "OFF";
            Console.WriteLine("Checking smart heating status...");
            Console.WriteLine($"Current smart heating status: {smartHeatingStatus}");
            Console.WriteLine($"Current temperature: {Temperature}°C");
            return IsSmartHeatingOn;
        }
    }
}