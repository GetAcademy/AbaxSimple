using System;
using System.Collections.Generic;
using System.Text;

namespace AbaxSimple
{
    abstract class Vehicle
    {
        public string RegNo { get; }
        public int Effect { get; }

        protected Vehicle(string regNo, int effect)
        {
            RegNo = regNo;
            Effect = effect;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine($" - Reg.nr. = {RegNo}");
            Console.WriteLine($" - Effekt = {Effect}kw");
        }

        public abstract void Run();
    }
}
