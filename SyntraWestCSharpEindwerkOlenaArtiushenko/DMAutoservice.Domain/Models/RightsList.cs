using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class RightsList
    {
        public static string ShowBrandDetails => "Can see a list of brands"; //internal code from Right class
        public static string CreateBrand => "Can Create New Brand";
        public static string DeleteBrand => "Can Delete Brand";
        public static string EditBrand => "Can Edit Brand";
        public static string ShowDetailsAccount => "Can See Details of the Account";
        public static string ShowBrandList => "Can See Details of the Brand";



        public static List<string> Rights = new List<string>
        {
            ShowBrandDetails,
            CreateBrand,
            DeleteBrand,
            EditBrand,
            ShowDetailsAccount,
            ShowBrandList

        };
    }
}
