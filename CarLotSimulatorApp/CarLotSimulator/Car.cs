using System;

namespace CarLotSimulator
{
	public class Car
	{
		public int Year { get; set; }
	    public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDrivable { get; set; }

		public void MakeEngineNoise(string EngineNoise)
		{
			Console.WriteLine($"The engine noise is described as a {EngineNoise}.");
		}

		public void MakeHonkNoise(string HonkNoise)
	    {
			Console.WriteLine($"The horns honk sounds like {HonkNoise}.");
		}
	}
}
