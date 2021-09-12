using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class BasketService
    {
        private static double _totalPrice = 0;
        public void AddProductsToBasket()
        {
            var productProvider = new ProductProvider();
            var basket = new Basket();
            for (var i = 0; i < 10; i++)
            {
                var temp = productProvider.GetChosenProducts(i);
                basket.ProductsInBasket[i] = temp;
                if (temp != null)
                {
                    _totalPrice += basket.ProductsInBasket[i].Price;
                }
            }
        }

        public double GetTotalPrice()
        {
            return _totalPrice;
        }
    }
}
