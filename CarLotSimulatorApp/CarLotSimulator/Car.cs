using System;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkSounds { get; set; }
        public bool IsItDrivable { get; set; }
        public Car(int year, string make, string model, string engineNoise, string honkSounds, bool isItDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkSounds = honkSounds;
            IsItDrivable = isItDrivable;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"The quiet rating is: {EngineNoise}");
            Console.WriteLine($"The horn makes a {HonkSounds} sound.");
            Console.WriteLine($"Is this Vehicle drivable? {IsItDrivable}");
        }



    }
}
