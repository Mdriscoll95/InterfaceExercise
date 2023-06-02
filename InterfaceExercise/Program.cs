using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany----------DONE

            //Create 3 classes called Car , Truck , & SUV-------------DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.-------------DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany------------------------------------------------DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             *

        //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var subaru = new CarClass();
            subaru.Make = "suburu";
            subaru.Model = "WRX";
            subaru.SeatCount = 4;
            subaru.EngineSize = 5.6;
            subaru.IsElectric = false;
            subaru.CompanyName = "Subaru";
            subaru.Motto = "sub";

            var gmc = new TruckClass();
            gmc.Make = "GMC";
            gmc.Model = "Sierra";
            gmc.SeatCount = 4;
            gmc.EngineSize = 8.9;
            gmc.GasMileage = 30;
            gmc.bedLength = "6 feet";
            gmc.CompanyName = "GMC";
            gmc.Motto = "GMC is here";

            var macan = new SUVClass();
            macan.Make = "Porche";
            macan.Model = "Macan";
            macan.SeatCount = 6;
            macan.EngineSize = 10;
            macan.IsGas = true;
            macan.HatchBack = true;
            macan.CompanyName = "Porche";
            macan.Motto = "Luxary, realized";


            var parkingLot = new List<IVehicle>() { subaru, gmc, macan };
            foreach(var vehicle in parkingLot)
            {
              Console.WriteLine($"make: {vehicle.Make}\n model: {vehicle.Model}");

            }
            
            

           

            

            
        }
    }
}
