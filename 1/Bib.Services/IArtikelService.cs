using System.Collections.Generic;
using Bib.Domein;
using Bib.DAL;

namespace Bib.Services
{
    public interface IArtikelService
    {
        List<Artikel> GetAllArtikles();
        void ToonArtikel();
        void ToonArtikelen();
        void ToonOntleendeArtikelen();

    }
}