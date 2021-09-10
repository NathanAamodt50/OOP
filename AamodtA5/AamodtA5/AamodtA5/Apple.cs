using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreNS
{
    public class Apple:AppStore
    {
        
        protected override void Welcome()
        {
            Console.WriteLine("Welcome to the Apple Store!\nPlease Choose an Item!");
        }
        protected override void BuyApp(ref App Soul)
        {
            int cost;
            int ten;
            int five;
            int one;

            Console.WriteLine("Please Enter Your Payment Meathod.\n");
            Console.WriteLine("$10 Bills:");
            ten = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("$5 Bills:");
            five = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("$1 Bills:");
            one = Convert.ToInt32(Console.ReadLine());

            cost = (ten * 10) + (five * 5) + one;

            ReturnChange(Soul, cost);

            DownloadApp(ref Soul, cost);
        }
    }
}
