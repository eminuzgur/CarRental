using CarRental.Entities.Concrete;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage);
    }
}
