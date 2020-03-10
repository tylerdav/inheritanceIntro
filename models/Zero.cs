using System;

namespace inheritanceIntro
{
    public class Zero : vehicle
    { // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery () { }

        public override void Turn ()
        {
            Console.WriteLine ($"The {Name} turned to the left.");
        }
    }
}