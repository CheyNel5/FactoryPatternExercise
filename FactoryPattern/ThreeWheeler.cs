using System;
namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The ThreeWheeler is kicking up mud!");
        }
    }
}
