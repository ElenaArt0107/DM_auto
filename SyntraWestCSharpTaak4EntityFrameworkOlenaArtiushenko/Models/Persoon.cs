using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models
{
    public class Persoon
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public int HuisId { get; set; }


        //prop nav

        public Huis Huis { get; set; }
        public List<HobbyPerPersoon> HobiesPerPersoon { get; set; } = new List<HobbyPerPersoon>();
    }
}
