using System;

namespace inheritanceIntro
{
    class Program
    {
        static void Main (string[] args)
        {
            var myBike = new Zero ();

            // i can still refrence the inherited properity
            myBike.Name = "Zero";
            myBike.MainColor = "Midnight Black";
            myBike.MaximumOccupancy = 2;

            var myTesla = new Tesla ();
            myTesla.Name = "Tesla";
            myTesla.MainColor = "Space Gray";
            myTesla.MaximumOccupancy = 5;

            var myRam = new Ram ();
            myRam.Name = "Ram";
            myRam.MainColor = "Rocket Red";
            myRam.MaximumOccupancy = 5;

            var myCessna = new Cessna ();
            myCessna.Name = "Cessna";
            myCessna.MainColor = "Blue and White";
            myCessna.MaximumOccupancy = 8;

            myBike.Drive ();
            myBike.Turn ();
            myBike.stop ();

            Console.WriteLine ("-------------------------------------");

            myTesla.Drive ();
            myTesla.Turn ();
            myTesla.stop ();

            Console.WriteLine ("-------------------------------------");

            myRam.Drive ();
            myRam.Turn ();
            myRam.stop ();

            Console.WriteLine ("-------------------------------------");

            myCessna.Drive ();
            myCessna.Turn ();
            myCessna.stop ();

        }
    }
}