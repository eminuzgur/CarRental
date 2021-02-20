﻿using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalDbContext>, IUserDal
    {
    }
}
