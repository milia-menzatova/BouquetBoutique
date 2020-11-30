using System.Linq;
using System.Security.AccessControl;
using System.Collections.Generic;
using BouquetBoutiqueLibrary.Model;

namespace BouquetBoutiqueMvc.Models
{
    public class CartViewModel
    {

        public CartViewModel() 
        {
            this.items = new List<Bouquet>();
        }

        public List<Bouquet> items { get; set; }

        public int Size() 
        {
            return this.items.Count;
        }

        public bool IsEmpty() 
        {
            return this.Size() == 0;
        }

        public double GetTotalPrice() 
        {
            double total = 0d;
            foreach (var bouquet in this.items)
            {
                total = total + bouquet.Price;
            }
            return total;
        }
    }
}