using System;

namespace SmartHomeApp
{
    abstract class SmartHome
    {
        private Guid smartDeviceId = Guid.NewGuid();
        private int electricityConsumption = 0; 

        public Guid SmartDeviceId { get => smartDeviceId; } // Setter removed so the user can't change ID
        protected int ElectricityConsumption
        {
            get => electricityConsumption;
            set => electricityConsumption = value;
        }

        public int GetElectricityConsumption()
        {
            return electricityConsumption;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract bool GetStatus();
    }
}