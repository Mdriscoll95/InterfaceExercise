using System;
namespace InterfaceExercise
{
	public interface IVehicle : ICompany
	{
		public double EngineSize { get; set;}
		public string Make { get; set; }
		public string Model { get; set; }
		public int SeatCount { get; set; }
	}
}

