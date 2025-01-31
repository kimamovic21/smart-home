using System;

namespace SmartHomeApp
{
    public abstract class SmartHome
    {
            public abstract void TurnOn();
            public abstract void TurnOff();
            public abstract void GetStatus();
    }
}