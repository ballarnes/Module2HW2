using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class NotificationService
    {
        public void ChooseTypeOfNotification(string name, string email, string number, double totalprice, Currency currency)
        {
            if (email != null)
            {
                var emailService = new EmailService();
                emailService.EmailNotification(name, email, totalprice, currency);
            }
            else
            {
                var smsService = new SmsService();
                smsService.SmsNotification(name, number, totalprice, currency);
            }
        }
    }
}
