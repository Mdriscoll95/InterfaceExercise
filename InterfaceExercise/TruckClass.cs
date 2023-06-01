using System;
namespace InterfaceExercise
{
	public class TruckClass : IVehicle, ICompany 
	{
		public TruckClass()
		{
		}
        //Car interface
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

        //Company Interface
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        //Truck class
        public int GasMileage { get; set; }
        public string bedLength { get; set; }
    }
}

