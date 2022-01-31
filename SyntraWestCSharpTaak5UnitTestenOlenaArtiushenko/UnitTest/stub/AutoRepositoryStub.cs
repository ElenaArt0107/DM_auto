using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace UnitTest.stub
{
    public class AutoRepositoryStub : IAutoRepository
    {
        public Auto GetAuto(int id)
        {
            var fakeId = 2;

            if (id == fakeId)
            {
                return new Auto
                {
                    Id = 2,
                    Kleur = "white",
                    Prijs = 25000.05m
                };
            }
            else
            {
                return null;
            }
        }

        public List<Auto> GetAutos()
        {
            return new List<Auto>()
            {
                new Auto
                {
                    Id = 2,
                    Kleur = "white",
                    Prijs = 25000.05m
                },
                new Auto
                {
                    Id = 2,
                    Kleur = "white",
                    Prijs = 25000.05m
                }
            };
        }

        public decimal GetPrijsVanAlleAutos()
        {
            throw new NotImplementedException();
        }
    }
}
