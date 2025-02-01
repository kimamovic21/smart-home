using System;

namespace SmartHomeApp
{
    public abstract class SmartHome
    {
        private Guid smartDeviceId = Guid.NewGuid();
        public Guid SmartDeviceId { get => smartDeviceId; } //Setter removed so the user can't change ID

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract bool GetStatus();
    }
}