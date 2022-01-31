using Domain;
using Domain.models;
using System;
using System.Collections.Generic;

namespace Services
{
    public interface IRekeningService
    {
        List<Rekening> GetRekeningenSortedOnBalansDesc();
        Rekening GetRekening(int id);
        void UpdateRekening(Rekening rekening);
        void CreateRekenig(Rekening rekening);
        void DeleteRekening(int id);
    }
}
