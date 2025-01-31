namespace SmartHomeApp
{
    internal class SmartAlarm
    {
        private bool isAlarmOn;

        public void TurnOnAlarm()
        {
            isAlarmOn = true;
            Console.WriteLine("Alarm is now ON!");
        }

        public void TurnOffAlarm()
        {
            isAlarmOn = false;
            Console.WriteLine("Alarm is now OFF!");
        }

        public void GetAlarmStatus()
        {
            string status = isAlarmOn ? "ON" : "OFF";
            Console.WriteLine($"Current alarm status: {status}");
        }
    }
}