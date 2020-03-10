using System;

namespace inheritanceIntro
{
    public class Tesla : vehicle
    { // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery () { }

        public override void Drive ()
        {
            Console.WriteLine ($"The {MainColor} {Name} has a Max Occupancy of {MaximumOccupancy}. Zoooooom!");
        }
        public override void Turn ()
        {
            Console.WriteLine ($"The {Name} did not turn.");
        }

        public override string ToString ()
        {
            return "This is my tesla";
        }
    }
}