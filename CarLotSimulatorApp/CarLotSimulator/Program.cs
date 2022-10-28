using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            Carlot CodersCarLot = new Carlot();


            //Now that the Car class is created we can instanciate 3 new cars

            Car car = new Car();
            Car car1 = new Car();
            Car car2 = new Car();

            //Set the properties for each of the cars

            car.Year = "2022";
            car.Make = "Ford";
            car.Model = "Mustang";
            car.EngineNoise = "None";
            car.HonkNoise = "None";
            car.IsDriveable = true;
            CodersCarLot.Cars.Add(car);

            car1.Year = "2001";
            car1.Make = "Mitsubishi";
            car1.Model = "Eclipse";
            car1.EngineNoise = "None";
            car1.HonkNoise = "None";
            car1.IsDriveable = true;
            CodersCarLot.Cars.Add(car1);


            car2.Year = "1987";
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.EngineNoise = "None";
            car2.HonkNoise = "None";
            car2.IsDriveable = true;
            CodersCarLot.Cars.Add(car2);


            //Call each of the methods for each car

            car1.MakeEngineNoise("Vroom");
            car1.MakeHonkNoise("Bep");

            car2.MakeEngineNoise("Bram");
            car2.MakeHonkNoise("Buuga");

            car.MakeEngineNoise("Bap");
            car.MakeHonkNoise("Beep");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var c in CodersCarLot.Cars) 
            {
                Console.WriteLine(c);
                
            }

        }
    }
}
