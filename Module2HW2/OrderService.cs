using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class OrderService
    {
        public void OrderProducts(User user)
        {
            var bucketService = new BucketService();
            var notificationService = new NotificationService();
            double totalPrice = bucketService.GetTotalPrice();
            if (user.PrefferedCurrency == Currency.UAH)
            {
                var currencyservice = new CurrencyService();
                double prefferedTotalPrice = currencyservice.ConvertationToUAH(totalPrice);
                notificationService.ChooseTypeOfNotification(user.Name, user.Email, user.Number, prefferedTotalPrice, Currency.UAH);
            }
            else
            {
                notificationService.ChooseTypeOfNotification(user.Name, user.Email, user.Number, totalPrice, Currency.USD);
            }
        }
    }
}
