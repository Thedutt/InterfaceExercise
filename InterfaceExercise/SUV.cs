using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV:IVehicle,ICompany
    {
        public double EngSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatNum { get; set; }
        public void Drive()
        {
            Console.WriteLine("The SUV does drive");
        }
        public void Reverse()
        {
            Console.WriteLine("The SUV does drive in reverse");
        }
        public void Park()
        {
            Console.WriteLine("The SUV is able to park");
        }

        public string Name { get; set; }
        public string Slogan { get; set; }

    }
}
