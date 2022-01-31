using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IAutoService
    {
        public Auto GetAuto(int id);
        public List<Auto> GetAutos();
        public decimal GetPrijsVanAlleAutos();
    }
}
