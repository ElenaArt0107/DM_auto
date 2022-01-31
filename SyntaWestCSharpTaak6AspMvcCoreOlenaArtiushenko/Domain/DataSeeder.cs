using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public static class DataSeeder
    {
        public static void SeedData(RekeningContext context)
        {
            return; //(in production: test data should not be insert anymore)
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            if (context.Rekeningen.Any())
            {
                return;
            }

            #region Rekeningen
            var Rekening1 = new Rekening
            {
                //Id = 1,
                OpNaamVan = "Elli Boom",
                RekeningType = "personal",
                Balans = 5000.85m
            };
            context.Rekeningen.Add(Rekening1);

            var Rekening2 = new Rekening
            {
               // Id = 2,
                OpNaamVan = "Enni Penni BV",
                RekeningType = "business",
                Balans = 1777000.85m
            };
            context.Rekeningen.Add(Rekening2);

            var Rekening3 = new Rekening
            {
                //Id = 3,
                OpNaamVan = "Lilly Rose",
                RekeningType = "personal",
                Balans = 00.85m
            };
            context.Rekeningen.Add(Rekening3);

            var Rekening4 = new Rekening
            {
                //Id = 4, the IDENTITY_INSERT is set to off, how can i set it to on from c#?
                OpNaamVan = "Rose Melrose",
                RekeningType = "personal",
                Balans = 3600.85m
            };
            context.Rekeningen.Add(Rekening4);

            #endregion

            context.SaveChanges();
        }
    }
}
