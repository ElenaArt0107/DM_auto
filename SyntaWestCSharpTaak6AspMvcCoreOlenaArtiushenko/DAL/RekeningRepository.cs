using Domain;
using Domain.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class RekeningRepository : IRekeningRepository
    {
        //dependency 
        private readonly RekeningContext _context;
        public RekeningRepository(RekeningContext context)
        {
            _context = context;
        }
        // implementation
        public int CreateRekenig(Rekening rekening)
        {
            _context.Add(rekening);
            _context.SaveChanges();
            return rekening.Id;
        }

        public void DeleteRekening(int id)
        {
            Rekening rekening = GetRekening(id);
            _context.Remove(rekening);
            _context.SaveChanges();
        }

        public Rekening GetRekening(int id)
        {
            return _context.Rekeningen.
                Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Rekening> GetRekeningen()
        {
            return _context.Rekeningen.
                ToList();
        }

        public void UpdateRekening(Rekening rekening)
        {
            Rekening rekeningToUpdate = GetRekening(rekening.Id);
            rekeningToUpdate.Balans = rekening.Balans;
            rekeningToUpdate.OpNaamVan = rekening.OpNaamVan;
            rekeningToUpdate.RekeningType = rekening.RekeningType;
            _context.SaveChanges();
        }
    }
}
