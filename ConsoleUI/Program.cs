using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles



            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles


            List<Vehicle> vehicles = new List<Vehicle>();

            Car johnsC = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 2013 };

            Motorcycle alinasM = new Motorcycle() { HasSideCart = false, Make = "Harley", Model = "Choppah", Year = 1995 };

            Vehicle justinsC = new Car() { HasTrunk = false, Make = "Dodge", Model = "Ram", Year = 2010};

            Vehicle crystalineC = new Car() { HasTrunk = true, Make = "Hundai", Model = "Something", Year = 2015 };

            vehicles.Add(johnsC);
            vehicles.Add(justinsC);
            vehicles.Add(alinasM);
            vehicles.Add(crystalineC);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}, Year:  {vehicle.Year}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine("-----------------------");
                
            }

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
