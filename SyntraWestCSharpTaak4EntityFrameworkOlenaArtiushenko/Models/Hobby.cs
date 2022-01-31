using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Naam { get; set; }


        //nav prop
        public List<HobbyPerPersoon> PeoplePerHobby { get; set; } = new List<HobbyPerPersoon>();
    }
}
