using System.Collections.Generic;
using Bib.Domein;
using Bib.DAL;

namespace Bib.Services
{
    public interface IOntleningenService
    {
        List<Ontlening> GetOntlenings();
        void BrengOntleendArtikelBinnen(int ontleningId);
        void OntleenArtikel(int artikelId, string voornaam, string familienaam);

    }
}