﻿using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarRental.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null);
    }
}
