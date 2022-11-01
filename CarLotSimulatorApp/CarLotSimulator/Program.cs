using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var focus = new Car();
            focus.Make = "Benz";
            focus.Model = "GT63 S";
            focus.Year = 2023;
            focus.EngineNoise = "vroom";
            focus.HonkNoise = "honk";
            focus.IsDrivable = true;

            carLot.ParkingLot.Add(focus);

            var kaisCar = new Car()
            {
                Year = 2019,
                Make = "Volkswagon",
                Model = "Jetta",
                EngineNoise = "hmmm",
                HonkNoise = "beep",
                IsDrivable = true
            };

            carLot.ParkingLot.Add(kaisCar);

            var willsCar = new Car(2020, "Chevy", "Impala", "mroom", "beep", true);

            focus.MakeEngineNoise(kaisCar.EngineNoise);
            kaisCar.MakeEngineNoise(kaisCar.EngineNoise);
            willsCar.MakeEngineNoise(willsCar.EngineNoise);

            carLot.ParkingLot.Add(willsCar);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars made: {CarLot.numberOfCars}");


            foreach(var vehicle in carLot.ParkingLot)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");

            }

        }
    }
}
