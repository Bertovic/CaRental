using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CaRental.Models
{
    public class CarDatabaseInitializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetCars().ForEach(cr => context.Cars.Add(cr));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Regular"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "SUV"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Sports"
                },
            };
            return categories;
        }

        private static List<Car> GetCars()
        {
            var cars = new List<Car>
            {
                new Car
                {
                    CarID = 1,
                    CarName = "Honda Civic",
                    Description= "2015, Silver, Coupe",
                    Images ="Honda 1.jpg",
                    UnitPrice =45.00,
                    CategoryID = 3
                },
                new Car
                {
                    CarID = 2,
                    CarName = "Honda Civic",
                    Description= "2015, Black, Sedan",
                    Images ="Honda 2.jpg",
                    UnitPrice =40.00,
                    CategoryID = 1
                },
                new Car
                {
                    CarID = 3,
                    CarName = "Honda Civic",
                    Description= "2015, Brown, Sedan",
                    Images ="Honda 3.jpg",
                    UnitPrice =40.00,
                    CategoryID = 1
                },
                new Car
                {
                    CarID = 4,
                    CarName = "Honda CR-V",
                    Description= "2015, White, SUV",
                    Images ="SUV 1.jpg",
                    UnitPrice =60.00,
                    CategoryID = 2
                },
                new Car
                {
                    CarID = 5,
                    CarName = "Toyota Rav4",
                    Description= "2015, Black, SUV",
                    Images ="SUV 2.jpg",
                    UnitPrice =55.00,
                    CategoryID = 2
                },
                new Car
                {
                    CarID = 6,
                    CarName = "Suzuki Vitara",
                    Description= "2015, White, SUV",
                    Images ="SUV 3.png",
                    UnitPrice =55.00,
                    CategoryID = 2
                },
            };
            return cars;
        }
    }
}