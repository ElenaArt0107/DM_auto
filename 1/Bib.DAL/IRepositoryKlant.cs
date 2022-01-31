using System.Collections.Generic;
using Bib.Domein;

namespace Bib.DAL
{
    public interface IRepositoryKlant
    {
        List<Klant> GetKlanten();
        Klant GetKlantByNaam(string voornaam, string familienaam);
        void InsertKlant(Klant k);
    }
}