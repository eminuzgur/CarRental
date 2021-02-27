using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entities.Concrete
{
   public class CarImage:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Path { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
