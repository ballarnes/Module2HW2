using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class ProductProvider
    {
        private static Product[] _chosenProducts = new Product[10];

        public Product[] ChosenProducts
        {
            get
            {
                return _chosenProducts;
            }
        }

        public Product GetChosenProducts(int i)
        {
            return _chosenProducts[i];
        }
    }
}