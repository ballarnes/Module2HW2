using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class BucketService
    {
        private static double _totalPrice = 0;
        public void AddProductsToBucket()
        {
            var productProvider = new ProductProvider();
            var bucket = new Bucket();
            for (var i = 0; i < 10; i++)
            {
                var temp = productProvider.GetChosenProducts(i);
                bucket.ProductsInBucket[i] = temp;
                if (temp != null)
                {
                    _totalPrice += bucket.ProductsInBucket[i].Price;
                }
            }
        }

        public double GetTotalPrice()
        {
            return _totalPrice;
        }
    }
}
