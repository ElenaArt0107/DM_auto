using System.Collections.Generic;
using Bib.Domein;

namespace Bib.DAL
{
    public interface IRepositoryOntlening
    {
        List<Ontlening> GetOntleningen();
        Ontlening GetOntleningByVolnumb(int volgnum);
        void InsertOntlening(Artikel artikel, Klant klant);
        void UpdateOntlening(int ontleningId);
    }
}