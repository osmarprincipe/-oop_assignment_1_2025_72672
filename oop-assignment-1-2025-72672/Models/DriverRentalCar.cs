using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_1_2025_72672.Models
{
    public static class DriverRentalCar
    {
        public static void Run()
        {
            RentalCar car1 = new RentalCar("Toyota", "Corolla", "Sedan", "191-D-12345", 45.0);
            RentalCar car2 = new RentalCar("Honda", "Civic", "Sedan", "182-D-54321", 50.0);
            RentalCar car3 = new RentalCar("Ford", "Focus", "Hatchback", "201-D-98765", 40.0);
            RentalCar car4 = new RentalCar("BMW", "X1", "SUV", "202-D-11111", 90.0);

            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();

        }

    }
}
