using System.Collections.Generic;
using BouquetBoutiqueLibrary.Model;

namespace BouquetBoutiqueLibrary.Storage
{
    public class BouquetDatabaseStorage : IBouquetStorage
    {
        public void AddBouquet(Bouquet bouquet)
        {

        }

        public void AddBouquets(ICollection<Bouquet> bouquets)
        {

        }

        public Bouquet FindByName(string bouquetName)
        {
            return null;
        }

        public Bouquet FindById(string bouquetId) 
        {
            return null;
        }

        public void RemoveBouquet(Bouquet bouquet)
        {
        }

        public ICollection<Bouquet> GetAll(int fromIndex, int limit)
        {
            return null;
        }

        public ICollection<Bouquet> GetAll()
        {
            return null;
        }
    }
}