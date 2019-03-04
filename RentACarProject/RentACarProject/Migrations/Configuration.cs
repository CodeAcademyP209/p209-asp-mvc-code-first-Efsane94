namespace RentACarProject.Migrations
{
    using RentACarProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RentACarProject.DAL.CarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RentACarProject.DAL.CarContext context)
        {
            context.Cars.AddOrUpdate(x => new { x.Brand, x.Model },
                new Car() { Id = 1, Brand = "Porsche", Model = "Panamera Turbo S", Image = "Porsche.jpg", EngineVolume = "4.8 L", HorsePower = "550 a.g.", MotorType = "Hybrid", DateOfProduction = "2011", AmountOfMarch = "40 000 km" },
                new Car() { Id = 2, Brand = "BMW", Model = "528", Image = "BMV1.jpg", EngineVolume = "2.0 L", HorsePower = "245 a.g.", MotorType = "Benzin", DateOfProduction = "2014", AmountOfMarch = "84 100 km" },
                new Car() { Id = 3, Brand = "Mercedes", Model = "E 200", Image = "Mercedes.jpg", EngineVolume = "2.0 L", HorsePower = "184 a.g.", MotorType = "Benzin", DateOfProduction = "2015", AmountOfMarch = "75 000 km" });



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
