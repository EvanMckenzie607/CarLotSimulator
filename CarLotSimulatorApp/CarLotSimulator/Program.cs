using System;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();
            //List<Car> lotList = new List<Car>();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            Car car2 = new Car(2020, "Toyota", "Prius PHEV", "Silent", "Fart", true);
            Car car3 = new Car(2010, "Chrysler", "P.T. Cruiser", "AirPLane Loud", "cry for help", false);
            Car car4 = new Car()
            {
                Year = 2023,
                Make = "BMW",
                Model = "X4",
                EngineNoise = "Hums Like an Angel",
                HonkSounds = "a terrifing scream",
                IsItDrivable = true
            };

            car1.Year = 2019;
            car1.Make = "Ford";
            car1.Model = "Fusion PHEV";
            car1.EngineNoise = "Silent";
            car1.HonkSounds = "Musical";
            car1.IsItDrivable = true;

            carLot.carList.Add(car1);
            carLot.carList.Add(car2);
            carLot.carList.Add(car3);
            carLot.carList.Add(car4);

            Console.WriteLine("Here is a list of our availible vehicles:");
            Console.WriteLine("");

            car1.PrintCarInfo();
            Console.WriteLine("");
            car2.PrintCarInfo();
            Console.WriteLine("");
            car3.PrintCarInfo();
            Console.WriteLine("");
            car4.PrintCarInfo();
            Console.WriteLine("");
            Console.WriteLine("");

            foreach (var item in carLot.carList)
            {
                Console.WriteLine("");
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine("");

            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
