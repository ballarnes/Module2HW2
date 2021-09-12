using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Starter
    {
        public void Run()
        {
            var user1 = new User() { Name = "Alex", Email = "alex@email.com", Number = "+123456789", PrefferedCurrency = Currency.USD };
            var user2 = new User() { Name = "Maria", Number = "+987654321", PrefferedCurrency = Currency.UAH };
            var products = new ProductService();
            var bucketservice = new BucketService();
            var ordered = new OrderService();
            var bucket = new Bucket();
            products.AddProducts();
            products.ChooseProducts();
            bucketservice.AddProductsToBucket();
            int chooseUser = new Random().Next(1, 3);
            switch (chooseUser)
            {
                case 1:
                    ordered.OrderProducts(user1);
                    break;
                case 2:
                    ordered.OrderProducts(user2);
                    break;
            }
        }
    }
}
