using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.models
{
    public class Account
    {
        public int Id { get; set; }
        public string Gebruiksnaam { get; set; }
        public string Wachtwoord { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Adres { get; set; }
    }
}
