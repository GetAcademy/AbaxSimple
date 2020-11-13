using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxSimple
{
    class Plane : Vehicle
    {
        public int WingSpan { get; }
        public int LoadCapacity { get; }
        public int Weight { get; }

        public Plane(string regNo, int effect, int wingSpan, int loadCapacity, int weight)
            : base(regNo, effect)
        {
            WingSpan = wingSpan;
            LoadCapacity = loadCapacity;
            Weight = weight;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($" ** Fly ** ");
            base.PrintInformation();
            Console.WriteLine($" - Vingespenn = {WingSpan}m");
            Console.WriteLine($" - Lasteevne = {LoadCapacity}tonn");
            Console.WriteLine($" - Egenvekt = {Weight}tonn");
        }

        public override void Run()
        {
            Console.WriteLine("Flyr flyet");
        }
    }
}
