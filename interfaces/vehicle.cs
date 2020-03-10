using System;

namespace inheritanceIntro
{
    public class vehicle
    {
        public string Name { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive ()
        {
            Console.WriteLine ($"The {MainColor} {Name} has a Max Occupancy of {MaximumOccupancy} ");
        }
        public virtual void stop ()
        {
            Console.WriteLine ($"The vehicle gently rolls to a stop!");
        }
        public virtual void Turn ()
        {
            Console.WriteLine ($"The vehicle turned to the right");
        }

    }
}