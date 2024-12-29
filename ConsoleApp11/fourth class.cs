namespace ConsoleApp11
{ 
    public class Heater : HomeDevice
    {
        public Heater(string deviceName, int energyConsumption, bool IsOn) : base(deviceName, energyConsumption)
        { 
        }
    }
}