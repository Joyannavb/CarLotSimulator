using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();
            
            var Prius= new Car(); 
            lot.CarList.Add(Prius);
            Prius.Year = 2016;
            Prius.Make = "Toyota";
            Prius.Model = "Prius";
            Prius.EngineNoise = "quiet hum";
            Prius.IsDrivable = true;
            Prius.HonkNoise = "Beep";
            Prius.MakeEngineNoise(Prius.EngineNoise);
            Prius.MakeHonkNoise(Prius.HonkNoise);

            var Corolla = new Car() { Year = 2011, Make = "Toyota", Model = "Corolla", EngineNoise = "subtle grind", IsDrivable = false, HonkNoise = "loud beep"};
            lot.CarList.Add(Corolla);
            Corolla.MakeEngineNoise(Corolla.EngineNoise);
            Corolla.MakeHonkNoise(Corolla.HonkNoise);

            var Camary = new Car()
            {
                Year = 2017,
                Make = "Toyota",
                Model = "Camary",
                EngineNoise = "a suble hum",
                IsDrivable = true,
                HonkNoise = "quiet beep",
            };
            lot.CarList.Add(Camary);
            Camary.MakeEngineNoise(Camary.EngineNoise);
            Camary.MakeHonkNoise(Camary.HonkNoise);


            foreach (var car in lot.CarList)
            {
                Console.WriteLine($" Year:{ car.Year} Make: { car.Make} Model:{ car.Model}"  ); 
            }

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
