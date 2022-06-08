using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Oh we moving...ONWARD!");

        }
        public bool HasTrunk { get; set; } = true;
    }
}
