using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppStoreNS
{
    public class Microsoft:AppStore
    {
        protected override void Welcome()
        {
            Console.WriteLine("Welcome to the Microsoft Store\n Choose one of the Items listed below!");
        }
        public static void ReturnChange(App Soul, int paid)
        {
            int fives;
            int twos;
            int ones;
            int change;

            change = paid - Soul.Price;

            if(Soul.Price < paid)
            {
                fives = change / 5;
                change = change % 5;

                twos = change / 2;
                change = change % 2;

                ones = change;
            }
            else
            {
                fives = paid / 5;
                paid = paid % 5;

                twos = paid / 2;
                paid = paid % 2;

                ones = paid;
            }
            Console.WriteLine("Your Change is in ammount of bills.\n$5:" + fives + "\n$2:" + twos + "\n$1:" + ones);
        }
    }
}
