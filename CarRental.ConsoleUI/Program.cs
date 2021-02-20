using CarRental.Business.Abstract;
using CarRental.Business.Concrete;
using CarRental.DataAccess.Concrete;
using CarRental.Entities.Concrete;
using System;

namespace CarRental.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentalDeneme();
           //CarDeneme();

        }

        private static void CarDeneme()
        {
            ICarService carService = new CarManager(new EfCarDal());
            var result = carService.GetCarDetails(6);
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarId + "//" + car.BrandName + "//" + car.ColorName + "//" + car.DailyPrice + "//" + car.Description);
            }
            Console.WriteLine(result.Message);
        }

        private static void RentalDeneme()
        {
            IRentalService rentalService = new RentalManager(new EfRentalDal());
            var result = rentalService.GetRentalDetails(4);
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.Brand + "//" + rental.CustomerName + "//" + rental.Id + "//" + rental.CarId);
            }
            Console.WriteLine(result.Message);

            var result2 = rentalService.GetById(4);
            Console.WriteLine(result2.Data.CustomerId);
        }
    }
}
