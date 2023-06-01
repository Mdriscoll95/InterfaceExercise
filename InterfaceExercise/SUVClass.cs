using System;
namespace InterfaceExercise
{
	public class SUVClass : IVehicle, ICompany
	{
		public SUVClass()
		{
		}
        //Car Interface
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int SeatCount { get; set; }

        //Company Interface
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        // Car Class
        public bool IsGas { get; set; }
        public bool HatchBack { get; set; }
    }
}

