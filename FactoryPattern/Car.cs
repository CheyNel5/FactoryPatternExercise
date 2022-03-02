using System;
namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving!");
        }
    }
}
