using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RentACarProject.Models;

namespace RentACarProject.DAL
{
    public class CarContext :DbContext
    {
        public CarContext() :base("CarContext")
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}