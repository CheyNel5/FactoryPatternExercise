using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The motorcycle is revving up!");
            Console.WriteLine("vrooooom");
        }
    }
}
