using System.Collections.Generic;
using Bib.Domein;

namespace Bib.DAL
{
    internal interface IRepositoryArtikel
    {
        List<Artikel> GetArtikels();
        Artikel GetArtikelByVolgNumb(int artikelId);
        void UpdateArtikel(int artikelId, bool isOntleen);

    }
}