using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car:IVehicle,ICompany
    {
        public double EngSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatNum { get; set; }
        public void Drive()
        {
            Console.WriteLine("The car does drive");
        }
        public void Reverse()
        {
            Console.WriteLine("The car does drive in reverse");
        }
        public void Park()
        {
            Console.WriteLine("The car is able to park");
        }
        
        public string Name { get; set; }
        public string Slogan { get; set; }

    }
}
