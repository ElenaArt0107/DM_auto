using System;
using System.Collections.Generic;
using System.Text;

namespace EF2Check.models
{
    public class Persoon
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int FavouriteBierId1 { get; set; }
        public int? FavouriteBierId2 { get; set; }

    //nav prop
        public Bier FavouriteBier1 { get; set; }
        public Bier FavouriteBier2 { get; set; }
    }
}
