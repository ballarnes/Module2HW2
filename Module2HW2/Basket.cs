using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Basket
    {
        private static Product[] _productsInBasket = new Product[10];

        public Product[] ProductsInBasket
        {
            get
            {
                return _productsInBasket;
            }
        }
    }
}
