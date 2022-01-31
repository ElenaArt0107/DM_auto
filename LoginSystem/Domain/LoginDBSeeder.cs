using System;
using System.Collections.Generic;
using System.Text;
using Domain.models;

namespace Domain
{
    public static class LoginDBSeeder
    {
        private static LoginContext _context;
        public static void SeedData(LoginContext context) 
        {
            _context = context;

            var testOmgeving = true; // in configuration file

            if (!testOmgeving)
            {
                var admin = new Account
                {
                    Id = 1,
                    Gebruiksnaam = "El",
                    Wachtwoord = "12345"
                };
            }
        }


    }
}
