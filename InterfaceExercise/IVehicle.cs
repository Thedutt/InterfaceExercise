using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public double EngSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatNum { get; set; }
        public void Drive();
        public void Reverse();
        public void Park();
     
    }
}
