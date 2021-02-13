using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            rentalManagerTest();
            //carManagerTest();
            //colorManagerTest();
            //brandManagerTest();


        }

        private static void rentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine($" RentalID : {rental.RentalId}\n FirstName : {rental.FirstName}\n LastName : {rental.LastName}\n BrandName : {rental.BrandName}\n RentDate : {rental.RentDate}\n ReturnDate : {rental.ReturnDate}\n----------------------------------------- ");
                }
            }
        }

        private static void brandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }

        }

        private static void colorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
        }

        private static void carManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($" CarID : {car.CarId}\n Brand: { car.BrandName}\n Color: { car.ColorName}\n Daily Price : { car.DailyPrice}\n Description : {car.Description}\n---------------------------------------------\n");
                }
            }

        }
    }
}
