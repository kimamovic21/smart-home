using System;

namespace SmartHomeApp
{
    internal class SmartAirConditioner : SmartHome
    {
        private bool isSmartAirConditionerOn = false;
        private int temperature = 20; //Default temperature
        private int requiredElectricity = 100;
        public int RequiredElectricity { get => requiredElectricity; }
        public bool IsSmartAirConditionerOn { get => isSmartAirConditionerOn; set => isSmartAirConditionerOn = value; }
        public int Temperature { get => temperature; set => temperature = value; }

        public SmartAirConditioner()
        {
        }

        public SmartAirConditioner(bool isSmartAirConditionerOn, int temperature)
        {
            IsSmartAirConditionerOn = isSmartAirConditionerOn;
            Temperature = temperature;
        }

        public override void TurnOn()
        {
            if (IsSmartAirConditionerOn == false)
            {
                IsSmartAirConditionerOn = true;
                ElectricityConsumption += RequiredElectricity;
                Console.WriteLine("Smart air conditioner is now ON!");
                this.GetStatus();
            }
            else
            {
                Console.WriteLine("Smart air conditioner is already ON!");
            }
        }

        public override void TurnOff()
        {
            if (IsSmartAirConditionerOn == true)
            {
                IsSmartAirConditionerOn = false;
                ElectricityConsumption -= RequiredElectricity;
                Console.WriteLine("Smart air conditioner is now OFF!");
            }
            else
            {
                Console.WriteLine("Smart air conditioner is already OFF!");
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
                Console.WriteLine($"Setting smart air conditioner temperature to {Temperature}°C...");
            }
        }

        public override bool GetStatus()
        {
            string smartAirConditionerStatus = IsSmartAirConditionerOn ? "ON" : "OFF";
            Console.WriteLine($"Current smart air conditioner status: {smartAirConditionerStatus}");
            Console.WriteLine($"Current smart air conditioner temperature: {Temperature}°C");
            return IsSmartAirConditionerOn;
        }
    }
}