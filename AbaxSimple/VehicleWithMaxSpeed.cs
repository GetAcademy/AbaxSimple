using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxSimple
{
    abstract class VehicleWithMaxSpeed : Vehicle
    {
        public int MaxSpeed { get; }
        public string MaxSpeedUnit { get; }

        protected VehicleWithMaxSpeed(int maxSpeed, string regNo, int effect, string maxSpeedUnit = "km/t") : base(regNo, effect)
        {
            MaxSpeed = maxSpeed;
            MaxSpeedUnit = maxSpeedUnit;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($" - Maksfart = {MaxSpeed}{MaxSpeedUnit}");
        }
    }
}
