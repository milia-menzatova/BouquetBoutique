using System;
using System.Collections.Generic;
using BouquetBoutiqueLibrary.Storage;
using BouquetBoutiqueLibrary.Model;

namespace BouquetBoutiqueLibrary.Manager
{
    public class DefaultBouquetManager : IBouquetManager
    {
        private IBouquetStorage bouquetStorage;

        public DefaultBouquetManager(IBouquetStorage bouquetStorage) 
        {
            this.bouquetStorage = bouquetStorage;

            this.bouquetStorage.AddBouquet(
                new Bouquet(Guid.NewGuid(), "Luxury", 150.00, "Luxury",
                    "https://cdn11.bigcommerce.com/s-a4z7rskb8w/images/stencil/original/products/379/760/romance-24-rose-bouquet-burnaby-florist-AR2035__21642.1583956443.jpg"));
            this.bouquetStorage.AddBouquet(
                    new Bouquet(Guid.NewGuid(), "Same Day Flowers", 99.99, "Same Day Flowers",
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR822ue5CxELFMqqDFi_umCmk-ryPCHoZ0Y3qKDwfYGaj-AuLR1oM3FjFDfGrx3OOWKJ8TTZW0&usqp=CAc"));
            this.bouquetStorage.AddBouquet(
                    new Bouquet(Guid.NewGuid(), "Peony Bouquet", 39.99, "Peony Bouquet",
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKPYTk8xyP94dllDuP66vZjt6NMMzgm7zUDxCyuYduOl-pLE2Jml2eDJFnScM_4GzzWMMJb2Cl&usqp=CAc"));
            this.bouquetStorage.AddBouquet(
                    new Bouquet(Guid.NewGuid(), "Rainbow", 39.99, "Rainbow",
                        "https://assets.eflorist.com/assets/products/PHR_/T282-9A.jpg"));
            this.bouquetStorage.AddBouquet(
                new Bouquet(Guid.NewGuid(), "Luxury", 150.00, "Luxury",
                    "https://cdn11.bigcommerce.com/s-a4z7rskb8w/images/stencil/original/products/379/760/romance-24-rose-bouquet-burnaby-florist-AR2035__21642.1583956443.jpg"));
            this.bouquetStorage.AddBouquet(
                    new Bouquet(Guid.NewGuid(), "Same Day Flowers", 99.99, "Same Day Flowers",
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR822ue5CxELFMqqDFi_umCmk-ryPCHoZ0Y3qKDwfYGaj-AuLR1oM3FjFDfGrx3OOWKJ8TTZW0&usqp=CAc"));
            this.bouquetStorage.AddBouquet(
                    new Bouquet(Guid.NewGuid(), "Peony Bouquet", 39.99, "Peony Bouquet",
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKPYTk8xyP94dllDuP66vZjt6NMMzgm7zUDxCyuYduOl-pLE2Jml2eDJFnScM_4GzzWMMJb2Cl&usqp=CAc"));
            this.bouquetStorage.AddBouquet(
                    new Bouquet(Guid.NewGuid(), "Rainbow", 39.99, "Rainbow",
                        "https://assets.eflorist.com/assets/products/PHR_/T282-9A.jpg"));
        }

        public ICollection<Bouquet> GetAll() 
        {
            return this.bouquetStorage.GetAll();
        }

        public Bouquet GetBouquetById(string id) 
        {
            return this.bouquetStorage.FindById(id);
        }

        public void RemoveBouquetById(string id)
        {
            Bouquet bouquet = this.GetBouquetById(id);
            if(bouquet != null) {
                this.bouquetStorage.RemoveBouquet(bouquet);
            }
        }
    }
}