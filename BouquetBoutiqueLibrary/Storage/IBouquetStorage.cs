using System.Collections.Generic;
using BouquetBoutiqueLibrary.Model;

namespace BouquetBoutiqueLibrary.Storage
{
    public interface IBouquetStorage
    {
        void AddBouquet(Bouquet bouquet);

        void AddBouquets(ICollection<Bouquet> bouquets);

        Bouquet FindByName(string bouquetName);

        Bouquet FindById(string bouquetId);

        void RemoveBouquet(Bouquet bouquet);

        ICollection<Bouquet> GetAll(int fromIndex, int limit);

        ICollection<Bouquet> GetAll();
    }
}