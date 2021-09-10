using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreNS
{
    public class App
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int Available { get; set; }

        public App(string N = "",int P = 0, int A = 0)
        {
            Name = N;
            Price = P;
            Available = A;
        }

        public App(App Soul)
        {
            Name = Soul.Name;
            Price = Soul.Price;
            Available = Soul.Available;
        }
    }
}
