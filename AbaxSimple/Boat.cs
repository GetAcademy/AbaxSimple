using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxSimple
{
    class Boat : VehicleWithMaxSpeed
    {
        public int GrossTonnage { get; }

        public Boat(string regNo, int effect, int maxSpeed, int grossTonnage) 
            : base(maxSpeed, regNo, effect, "knop")
        {
            GrossTonnage = grossTonnage;
        }

        public override void Run()
        {
            Console.WriteLine("Kjører båten");
        }

        public override void PrintInformation()
        {
            Console.WriteLine($" ** Båt ** ");
            base.PrintInformation();
            Console.WriteLine($" - Bruttotonnasje = {GrossTonnage}kg");
        }
    }
}
