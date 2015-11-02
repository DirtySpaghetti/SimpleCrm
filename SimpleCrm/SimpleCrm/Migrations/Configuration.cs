namespace SimpleCrm.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleCrm.Infrastructure.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleCrm.Infrastructure.AppDbContext context)
        {
            var brokerList = new List<Customer>
            {
                new Customer { FirstName = "Julius", MiddleName = "Cabatana", LastName = "Bacosa", City= "Cebu", Country="Philippines", EmailAddress="juliusbacosa@gmail.com", MobileNumber=09178284379, Telephone=4357555, BirthDay=DateTime.Parse("1983-10-29"), JobTitle="Asp.net C# Developer", StreetAddress="Busogon", YearlyIncome=45000, DateCreated=DateTime.Parse("2015-10-10") }
            };
            brokerList.ForEach(x => context.Customers.Add(x));
            context.SaveChanges();
        }
    }
}
