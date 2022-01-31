using System.Collections.Generic;
using Bib.Domein;
using Bib.DAL;

namespace Bib.Services
{
    public interface IKlantService
    {
        List<Klant> GetAllKlanten();
        void GetKlantByVolgNummer(int volgnummer);
        void ToonKlant();
        void ToonKlanten();
    }
}