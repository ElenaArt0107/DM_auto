using DAL;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class RekeningService : IRekeningService
    {
        private readonly IRekeningRepository _rekeningRepo;
        public RekeningService(IRekeningRepository rekeningRepo)
        {
            _rekeningRepo = rekeningRepo;
        }
        public void  CreateRekenig(Rekening rekening)
        {
            _rekeningRepo.CreateRekenig(rekening);
        }

        public void DeleteRekening(int id)
        {
            _rekeningRepo.DeleteRekening(id);
        }

        public Rekening GetRekening(int id)
        {
            return _rekeningRepo.GetRekening(id);

        }

        public List<Rekening> GetRekeningenSortedOnBalansDesc()
        {
            return _rekeningRepo.GetRekeningen().OrderByDescending(x=>x.Balans).ToList();
        }

        public void UpdateRekening(Rekening rekening)
        {
            _rekeningRepo.UpdateRekening(rekening);
        }
    }
}
