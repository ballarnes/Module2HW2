using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Bucket
    {
        private static Product[] _productsInBucket = new Product[10];

        public Product[] ProductsInBucket
        {
            get
            {
                return _productsInBucket;
            }
        }
    }
}
