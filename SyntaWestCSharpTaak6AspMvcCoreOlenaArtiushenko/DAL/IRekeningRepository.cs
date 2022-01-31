using Domain.models;
using System;
using System.Collections.Generic;

namespace DAL
{
    public interface IRekeningRepository
    {
        List<Rekening> GetRekeningen();
        Rekening GetRekening(int id);
        void UpdateRekening(Rekening rekening);
        int CreateRekenig(Rekening rekening);
        void DeleteRekening(int id);

    }
}
