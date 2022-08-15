using WalletPlusInc.Data.Entities;

namespace WalletPlusInc.Data
{
    public static class SeedHelper
    {
        public static async Task InitializeData(ApplicationDbContext context)
        {
            //1. check if customers contain data
            if (!context.Customers.Any())
            {
                //2. create sample data
                context.Customers.Add(new Customer
                {

                    FirstName = "ISHOLA",
                    LastName = "ABIOLA",
                    MiddleName = "ISAQ",
                    BirthDate = DateTime.Now.AddYears(-20),
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum2.Single,
                    CreatedDate = DateTime.Now,
                    Country = "Nigeria",
                    State = "IBADAN",
                    City = "IB",
                    Active = true
                });

                context.Customers.Add(new WalletPlusInc.Data.Entities.Customer
                {
                    FirstName = "ISHOLA",
                    LastName = "SAHEED",
                    MiddleName = "OMOWUMI",
                    BirthDate = DateTime.Now.AddYears(-10),
                    Gender = GenderEnum.Male,
                    MaritalStatus = MaritalStatusEnum2.Single,
                    Country = "Nigeria",
                    State= "IBADAN",
                    City = "LAGOS",
                    CreatedDate = DateTime.Now,
                    Active = false
                });

                await context.SaveChangesAsync();
            }

            if (!context.Countries.Any())
            {
               

                context.Countries.AddRange(new List<Country>
                {
                   new Country { Name = "Ghana", IsoCode = "GH", CallCode = "313" },
                    new Country { Name = "SouthAfrica", IsoCode = "SA", CallCode = "550" },
                     new Country { Name = "France", IsoCode = "FR", CallCode = "210" },
                });
                await context.SaveChangesAsync();
            }

            if (!context.Cities.Any())
            {
                context.Cities.AddRange(new List<City>
                {
                    new City { Name = "Lagos", IsoCode = "LOS", CallCode = "10100" },
                    new City { Name = "IKEGA", IsoCode = "IKJ", CallCode = "20007" },
                     new City { Name = "IKOYI", IsoCode = "VI", CallCode = "32001" },
                });
                await context.SaveChangesAsync();
            }

            if (!context.States.Any())
            {
                context.States.AddRange(new List<State>
                {
                    new State { Name = "Lagos", IsoCode = "Los", CallCode = "211" },
                    new State { Name = "kano", IsoCode = "KN", CallCode = "102" },
                     new State { Name = "Ogun", IsoCode = "OG", CallCode = "201" },
                });
                await context.SaveChangesAsync();
            }

        }
    }
}
