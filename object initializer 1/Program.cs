using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_initializer_1
{
    public class Car
    {
        public string CarName { get; set; }
        public string Color { get; set; }

        public CarManufacturer Manufacturer { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }

    }

    public class CarManufacturer
    {
        public static void Main()
        {
            Car car = new Car
            {
                CarName = "punto",
                Color = "Black",
                CompanyName = "Fiat",
                Country = "USA"


            };
            Console.WriteLine($" CarName:{car.CarName}");
            Console.WriteLine($" Color:{car.Color}");
            Console.WriteLine($" CompanyName:{car.CompanyName}");
            Console.WriteLine($" Country:{car.Country}");
            Console.ReadLine();
         }

   
    }

}


