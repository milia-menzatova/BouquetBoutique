
using System;

namespace BouquetBoutiqueLibrary.Model
{
    public class Bouquet
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }

        public Bouquet(Guid id, string name, double price, string description)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public Bouquet(string name, double price, string description)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Bouquet))
            {
                return false;
            }
            Bouquet other = obj as Bouquet;
            return this.id.Equals(other.id);
        }

        public override int GetHashCode()
        {
            if (this.id == null)
            {
                return 0;
            }
            else
            {
                return this.id.GetHashCode();
            }
        }
    }
}