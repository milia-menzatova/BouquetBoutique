using BouquetBoutiqueLibrary.Storage;

namespace BouquetBoutiqueLibrary.Manager
{
    public class DefaultBouquetManager : IBouquetManager
    {
        private IBouquetStorage bouquetStorage;

        public DefaultBouquetManager(IBouquetStorage bouquetStorage) 
        {
            this.bouquetStorage = bouquetStorage;
        }
    }
}