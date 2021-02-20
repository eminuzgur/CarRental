using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CarRental.DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalDbContext context=new CarRentalDbContext())
            {
                var result = from re in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars on re.CarId equals ca.Id
                             join cus in context.Customers on re.CustomerId equals cus.Id
                             join us in context.Users on cus.Id equals us.Id
                             join br in context.Brands on ca.BrandId equals br.Id
                             select new RentalDetailDto { 
                                 Id=re.Id,
                                 CarId=ca.Id,
                                 CustomerName=us.FirstName +" "+us.LastName,
                                 Brand=br.Name
                             };
                return result.ToList();
            }
        }
    }
}
