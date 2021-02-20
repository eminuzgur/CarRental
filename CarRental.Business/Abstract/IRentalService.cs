using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);


        IDataResult<List<RentalDetailDto>> GetRentalDetails(int rentalId);
    }
}
