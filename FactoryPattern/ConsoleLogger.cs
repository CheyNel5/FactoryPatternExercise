using System;
using System.Threading;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Put key in ignition!");
            Thread.Sleep(1000);
            Console.WriteLine("Turn the key!");
            Thread.Sleep(1000);
        }
    }
}
