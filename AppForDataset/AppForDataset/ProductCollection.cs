using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForDataset
{
    public class ProductCollection
    {
        private List<Product> products;

        public ProductCollection() 
        {
            products = new List<Product>();
        }
        public ProductCollection(List<Product> products) 
        {
            this.products = products;
        }

        public void Add(Product product) 
        {
            products.Add(product);
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                products.RemoveAt(index);
            }
        }

        public List<Product> GetProducts()
        {  
            return products.ToList(); 
        }

        public void UpdatePrice(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                products[index].UpdatePrice();
            }
        }

        public void UpdatePrice()
        {
            foreach (var p in products)
            {
                p.UpdatePrice();
            }
        }

    }
}
