using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class SmsService
    {
        public void SmsNotification(string name, string number, double totalprice, Currency currency)
        {
            Console.WriteLine($"Dear {name}! Thanks for your order. Purchase amount: {Math.Round(totalprice, 2)} {currency}. Number of the order: [№{new Random().Next(10000, 20000)}]");
            Console.WriteLine($"From +880502010 to {number}.");
        }
    }
}
