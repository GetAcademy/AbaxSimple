using System;

namespace AbaxSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car(
                "NF123456", 
                147, 
                200, 
                "grønn", 
                true);
            car1.PrintInformation();

            var car2 = new Car(
                "NF654321", 
                150, 
                195, 
                "blå", 
                true);
            car2.PrintInformation();

            var plane = new Plane("LN1234", 1000, 30, 2, 10);
            plane.PrintInformation();

            car1.Run();
            plane.Run();

            var boat = new Boat("ABC123", 100, 30, 500);
            boat.PrintInformation();
        }
    }
}
