namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        { 
            AirConditioner a = new AirConditioner("air condition", 36654,false); 
            Heater h= new Heater("warming", 001,true); 
            a.Run(); 
            a.TurnOn(); 
            a.SetEnergy(444); 
            h.Run(); 
            h.TurnOff();
            h.SetEnergy(1007); 
        }
    }
}

