using System.Collections.Generic;
using BouquetBoutiqueLibrary.Model;
namespace BouquetBoutiqueLibrary.Manager
{
    public interface IBouquetManager
    {
        ICollection<Bouquet> GetAll();

        Bouquet GetBouquetById(string id);

        void RemoveBouquetById(string id);
    }
}