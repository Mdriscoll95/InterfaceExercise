using System;
namespace InterfaceExercise
{
	public class CarClass : IVehicle , ICompany
	{
		public CarClass()
		{
		}
        
        

        
 
        //car class
        public bool IsElectric { get; set; }
        public int TrunkSpace { get; set; }

        //car interface
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

        //Company interface
        public string CompanyName { get; set; }
        public string Motto { get; set; }



    }
}

