using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AutoService : IAutoService
    {
        private readonly IAutoRepository _autoRepository;
        public List<Auto> Autos { get; set; } = new List<Auto>();

        public AutoService(IAutoRepository autoRepository)
        {

            _autoRepository = autoRepository;
        }

        public Auto GetAuto(int id)
        {
            return _autoRepository.GetAuto(id);
        }

        public List<Auto> GetAutos()
        {
           return _autoRepository.GetAutos();
        }

        public decimal GetPrijsVanAlleAutos()
        {
            decimal prijsVanAlleAutos = 0;
            foreach (var auto in _autoRepository.GetAutos())
            {
                prijsVanAlleAutos += auto.Prijs;
            };
            return prijsVanAlleAutos;
        }
    }
}
