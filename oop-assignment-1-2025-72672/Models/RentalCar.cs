using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_1_2025_72672.Models
{
    public class RentalCar
    {
        public string Manufacturer { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public string BodyType { get; set; } = String.Empty;
        public string RegistrationNumber { get; set; } = String.Empty;
        public double Price { get; set; } = 0.0;
        public bool Borrowed { get; set; } = false;

        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price, bool borrowed)
        {
            if (string.IsNullOrWhiteSpace(manufacturer) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(bodyType) || string.IsNullOrWhiteSpace(registrationNumber) || price <= 0)
            {
                Console.WriteLine("Invalid parameters provided.");
                throw new ArgumentException("Manufacturer, Model, BodyType or RegistrationNumber cannot be empty, and Daily Rate must be greater than zero.");
            }

            Manufacturer = manufacturer;
            Model = model;
            BodyType = bodyType;
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = borrowed;    

        }

        public void Display()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"BodyType: {BodyType}");
            Console.WriteLine($"RegistrationNumber: {RegistrationNumber}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Borrowed: {Borrowed}");
        }

        public bool Borrow()
        {
            if (!Borrowed)
            {
                Borrowed = true;
                Console.WriteLine($"RentalCar {Manufacturer} {Model} has been Borrowed.");
                return true;
            }
            else
            {
                Console.WriteLine($"CameraKit {Manufacturer} {Model} is already Borrowed.");
                return false;
            }
        }

        public void ReturnRentalCar()
        {
            if (Borrowed)
            {
                Borrowed = false;
                Console.WriteLine($"RentalCar {Manufacturer} {Model} has been Returned.");
            }
            else
            {
                Console.WriteLine($"RentalCar {Manufacturer} {Model} is not Rented.");
            }
        }
        public void ChangePrice(double NewPrice)
        {
            if (NewPrice > 0)
            {
                Price = NewPrice;
                Console.WriteLine($"RentalCar {Manufacturer} {Model} Price changed to {NewPrice}.");
            }
            else
            {
                Console.WriteLine("Invalid Price. Price must be greater than zero.");
            }
        }

        public double CheckPrice() => Price;
        public bool CheckBorrowed() => Borrowed;

        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price)
        {
            if (string.IsNullOrWhiteSpace(manufacturer) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(bodyType) || string.IsNullOrWhiteSpace(registrationNumber) || price <= 0)
            {
                Console.WriteLine("Invalid parameters provided.");
                throw new ArgumentException("Manufacturer, Model, BodyType or RegistrationNumber cannot be empty, and Daily Rate must be greater than zero.");
            }

            Manufacturer = manufacturer;
            Model = model;
            BodyType = bodyType;
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = false; 
        }
        public RentalCar(string manufacturer, string model, string bodyType)
        {
            if (string.IsNullOrWhiteSpace(manufacturer) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(bodyType))
            {
                Console.WriteLine("Invalid parameters provided.");
                throw new ArgumentException("Manufacturer, Model, BodyType or RegistrationNumber cannot be empty, and Daily Rate must be greater than zero.");
            }

            Manufacturer = manufacturer;
            Model = model;
            BodyType = bodyType;
            RegistrationNumber = "UNKNOWN"; 
            Price = 0.0;                   
            Borrowed = false;               
        }




    }
}

