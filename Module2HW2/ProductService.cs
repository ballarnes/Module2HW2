using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class ProductService
    {
        private Product[] _products = new Product[15];
        private int _quantityOfChosenProducts = new Random().Next(1, 10);
        public void AddProducts()
        {
            string[] names = { "Table", "Chair", "Sofa", "Closet", "Nightstand", "Armchair", "Lamp", "Mirror", "Carpet", "Dresser", "Curtains", "Painting \"Sunset\"", "Painting \"Winter\"", "Flower pot", "Chandelier" };
            for (var i = 0; i < 15; i++)
            {
                _products[i] = new Product() { Id = Guid.NewGuid(), Name = names[i], Price = new Random().Next(20, 120), IsExist = true, Currency = Currency.USD };
            }
        }

        public int GetQuantityOfChosenProducts()
        {
            return _quantityOfChosenProducts;
        }

        public void ChooseProducts()
        {
            var productProvider = new ProductProvider();
            for (var i = 0; i < _quantityOfChosenProducts; i++)
            {
                var randomProduct = new Random().Next(0, 14);
                productProvider.ChosenProducts[i] = _products[randomProduct];
                _products[randomProduct].IsExist = false;
            }
        }
    }
}
