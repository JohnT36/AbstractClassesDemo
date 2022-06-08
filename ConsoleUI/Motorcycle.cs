using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {

        public override void DriveAbstract()
        {
            Console.WriteLine("Oh we moving...slowly but surely!");
        }
        public bool HasSideCart { get; set; } = false;

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} is in drive!");
        }
    }
}
