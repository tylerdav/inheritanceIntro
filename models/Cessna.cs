using System;

namespace inheritanceIntro
{
    public class Cessna : vehicle
    { // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank () { }
        public override void Drive ()
        {
            Console.WriteLine ($"The {MainColor} {Name} flies around with a Max Occupancy of {MaximumOccupancy}. Swoosh!");
        }
        public override void stop ()
        {
            Console.WriteLine ($"The {MainColor} {Name} rolls to a stop after rolling a mile down the runway");
        }
    }
}