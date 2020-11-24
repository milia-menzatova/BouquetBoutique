using System.Collections.Generic;
using BouquetBoutiqueLibrary.Model;

namespace BouquetBoutiqueLibrary.Storage
{
    public class BouquetListStorage : IBouquetStorage
    {
        private List<Bouquet> bouquets;

        public BouquetListStorage()
        {
            this.bouquets = new List<Bouquet>();
        }


        public void AddBouquet(Bouquet bouquet)
        {
            this.bouquets.Add(bouquet);
        }

        public void AddBouquets(ICollection<Bouquet> bouquets)
        {
            foreach (var bouquet in bouquets)
            {
                this.AddBouquet(bouquet);
            }
        }

        public Bouquet FindByName(string bouquetName)
        {
            foreach (var bouquet in this.bouquets)
            {
                if (bouquetName.Equals(bouquet.name))
                {
                    return bouquet;
                }
            }
            return null;
        }

        public void RemoveBouquet(Bouquet bouquet)
        {
            bouquets.Remove(bouquet);
        }

        public ICollection<Bouquet> GetAll(int fromIndex, int limit)
        {
            return this.bouquets.GetRange(fromIndex, limit);
        }

        public ICollection<Bouquet> GetAll()
        {
            return this.bouquets;
        }
    }
}