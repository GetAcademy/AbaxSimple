using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxSimple
{
    class Car : VehicleWithMaxSpeed
    {
        public string Color { get; }
        public bool IsLightVehicle { get; }

        public Car(string regNo, int effect, int maxSpeed, string color, bool isLightVehicle)
        : base(maxSpeed, regNo, effect)
        {
            Color = color;
            IsLightVehicle = isLightVehicle;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($" ** Bil ** ");
            base.PrintInformation();
            Console.WriteLine($" - Farge = {Color}");
            if (IsLightVehicle) Console.WriteLine(" - Lett kjøretøy");
            //Console.WriteLine(IsLightVehicle ? " - Lett kjøretøy" : " (blankt eller Tungt kjøretøy)");
            Console.WriteLine();
        }

        public override void Run()
        {
            Console.WriteLine("Kjører bilen");
        }
    }
}
