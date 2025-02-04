using System;

namespace SmartHomeApp
{
    internal class SmartWaterHeater : SmartHome
    {
        private bool isSmartWaterHeaterOn = false;
        private int temperature = 30;
        private int requiredElectricity = 100;
        public int RequiredElectricity { get => requiredElectricity; }


        public bool IsSmartWaterHeaterOn { get => isSmartWaterHeaterOn; set => isSmartWaterHeaterOn = value; }
        public int Temperature { get => temperature; set => temperature = value; }

        public SmartWaterHeater()
        {
        }

        public SmartWaterHeater(bool isSmartWaterHeaterOn, int temperature)
        {
            IsSmartWaterHeaterOn = isSmartWaterHeaterOn;
            Temperature = temperature;
        }

        public override void TurnOn()
        {
            if (IsSmartWaterHeaterOn == false)
            {
                IsSmartWaterHeaterOn = true;
                ElectricityConsumption += RequiredElectricity;
                Console.WriteLine("Smart water heater is now ON!");
                this.GetStatus();
            }
            else
            {
                Console.WriteLine("Smart water heater is already ON!");
            }
        }

        public override void TurnOff()
        {
            if (IsSmartWaterHeaterOn == true)
            {
                IsSmartWaterHeaterOn = false;
                ElectricityConsumption -= RequiredElectricity;
                Console.WriteLine("Smart water heater is now OFF!");
            }
            else
            {
                Console.WriteLine("Smart water heater is already OFF!");
            }
        }

        public void SetTemperature(int newTemperature)
        {
            if (newTemperature < 20 || newTemperature > 50)
            {
                Console.WriteLine("Invalid temperature! Please set a value between 20°C and 50°C.");
            }
            else
            {
                Temperature = newTemperature;
                Console.WriteLine($"Setting smart water heater temperature to {Temperature}°C...");
            }
        }

        public override bool GetStatus()
        {
            string smartWaterHeaterStatus = IsSmartWaterHeaterOn ? "ON" : "OFF";
            Console.WriteLine($"Current smart water heater status: {smartWaterHeaterStatus}");
            Console.WriteLine($"Current temperature: {Temperature}°C");
            return IsSmartWaterHeaterOn;
        }
    }
}
