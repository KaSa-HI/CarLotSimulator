using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Carlot
    { 
        private static int numberOfCars = 0;


        private List<Car> cars { get; set; }
        public Carlot()
        {
            cars = new List<Car>();
        }

        public void Add(Car car)
        {
            cars.Add(car);
            numberOfCars++;
            Console.WriteLine($"The Total Number of Cars amongst all Car Lot is {numberOfCars}");
        }

        public override string ToString()
        {
            Console.WriteLine("");
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
               
            }

            return String.Empty;


        }
    }
}
