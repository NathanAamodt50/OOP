using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreNS
{
    abstract public class AppStore
    {
        protected App[] Souls = new App[55];
        protected int paid;
        protected int selected;


        public AppStore()
        {
            paid = 0;
            selected = 0;

        }

        protected abstract void Welcome();

        protected void SelectStore()
        {
            int choice;

            for (int f = 0; Souls[f] != null; f++)
            {
                Console.WriteLine((f + 1) + ". " + Souls[f].Name + "\t$"+ Souls[f].Price + "\t" + Souls[f].Available + "\n");
            }
            Console.WriteLine("Please Enter a Choice\nYou may also enter 0 to return to the home page");
            


            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 0)
            {

            }
            else
            {
                choice = choice - 1;
                if(Souls[choice] == null)
                {
                    Console.WriteLine("This option does not exist!\nPlease Try Again");
                    SelectStore();
                }
                else if(Souls[choice].Available == 0)
                {
                    Console.WriteLine("This Item Is out of stock!");
                    SelectStore();
                }
                else
                {
                    BuyApp(ref Souls[choice]);
                }
            }
        }
        public void Purchase()
        {
            Welcome();
            SelectStore();
        }

        protected virtual void BuyApp(ref App Soul)
        {
            int TotalPaid;
            int Twenty;
            int Ten;


            Console.WriteLine("Please Pay with 20 or 10 dollar bills\n");
            Console.Write("$20 bills:");

            Twenty = Convert.ToInt32(Console.ReadLine());

            Console.Write("$10 bills:");
            Ten = Convert.ToInt32(Console.ReadLine());

            TotalPaid = (Twenty * 20) + (Ten * 10);

            ReturnChange(Soul, TotalPaid);
            DownloadApp(ref Soul, TotalPaid);

        }

        protected virtual void ReturnChange(App Soul, int paid)
        {
            int tens;
            int ones;
            int change;

            change = paid - Soul.Price;

            if (Soul.Price < paid)
            {
                tens = change / 10;
                change = change % 10;

                ones = change;
            }
            else
            {
                tens = paid / 10;
                paid = paid % 10;

                ones = paid;
            }
            Console.WriteLine("Your Change is in ammount of bills.\n$10:" + tens + "\n$1:" + ones);
        }
        public void add(App Soul)
        {
            int num = 0;
            while (Souls[num] != null)
            {
                num++;
            }
            Souls[num] = Soul;
        }
        protected void DownloadApp(ref App Soul, int paid)
        {
            Console.WriteLine("Thank you for your purchase!\n" +
                "Your app is being downloaded now!" + "Hope you enjoy!");
        }

    }
}
