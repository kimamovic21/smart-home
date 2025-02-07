using SmartHomeApp;
internal class SmartLight : SmartHome
{
    private int brightness = 50;
    private int requiredElectricity = 20;
    private bool isSmartLightOn = false;

    public int RequiredElectricity { get => requiredElectricity; }

    public bool IsSmartLightOn
    {
        get => isSmartLightOn;
    }

    public int BrightnessLevel
    {
        get => brightness;
        set
        {
            if (value >= 1 && value <= 100)
            {
                brightness = value;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Brightness set to {brightness}%.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Brightness value must be between 1 and 100.");
            }
            Console.ResetColor();
        }
    }

    public override void TurnOn()
    {
        if (!isSmartLightOn)
        {
            isSmartLightOn = true;
            ElectricityConsumption += requiredElectricity;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Smart light is now ON with {brightness}% brightness.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Smart light is already ON!");
        }
        Console.ResetColor();
    }

    public override void TurnOff()
    {
        if (isSmartLightOn)
        {
            isSmartLightOn = false;
            ElectricityConsumption -= requiredElectricity;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Smart light is now OFF.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Smart light is already OFF!");
        }
        Console.ResetColor();
    }

    public override bool GetStatus()
    {
        string lightStatus = isSmartLightOn ? "ON" : "OFF";

        Console.ForegroundColor = isSmartLightOn ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Smart light status: {lightStatus} with {brightness}% brightness.");

        Console.ResetColor();

        return isSmartLightOn;
    }
}