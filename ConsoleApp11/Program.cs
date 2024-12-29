using System;

namespace ConsoleApp11
{
    public class HomeDevice
    {
        private string DeviceName;
        protected int EnergyConsumption;
        private bool IsOn;

        
        public HomeDevice(string DeviceName, int EnergyConsumption)
        {
            this.DeviceName = DeviceName;
            this.EnergyConsumption = EnergyConsumption;
            this.IsOn = false; 
        }

        
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine(DeviceName + "is working");
        }

        
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(DeviceName + "is off");
        }

        
        public void SetEnergy(int value)
        {
            EnergyConsumption = value;
            Console.WriteLine(DeviceName + " spending " + EnergyConsumption + " wt.");
        }

        
        public void Run()
        {
            Console.WriteLine("device: " + DeviceName + ", spending energy: " + EnergyConsumption + " wt: " + IsOn );
        }
    }
}