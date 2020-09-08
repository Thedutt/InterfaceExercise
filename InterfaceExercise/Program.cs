using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var myCar = new Car();

            var myTruck = new Truck();
            var mySUV = new SUV();

            var vehicles = new List<IVehicle>() { myCar, mySUV, myTruck };
            
            foreach (var veh in vehicles)
            {
                veh.Drive();
                veh.Reverse();
                veh.Park();
                Console.WriteLine("----------");

            }

        }
    }
}
