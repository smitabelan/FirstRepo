using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static int GetTotalPrice(List<Product> Products)
        {
            int CounterA = 0;
            int CounterB = 0;
            int CounterC = 0;
            int CounterD = 0;
            int PriceA = 50;
            int PriceB = 30;
            int PriceC = 20;
            int PriceD = 15;
            foreach (Product pr in Products)
            {
                switch (pr.Id.ToUpper())
                {
                    case "A": CounterA++; break;
                    case "B": CounterB++; break;
                    case "C": CounterC++; break;
                    case "D": CounterD++; break;
                }
                int ToatalPriceA = (CounterA / 3) * 130 + (CounterA % 3 * PriceA);
                int ToatalPriceB = (CounterB / 2) * 45 + (CounterA % 2 * PriceB);
                int ToatalPriceC = (CounterC * PriceC);
                int ToatalPriceD = (CounterD * PriceD);
                return ToatalPriceA + ToatalPriceB + ToatalPriceC + ToatalPriceD;
            }
        }
    }

    public  class Product
    {
        public string Id { get; set; }
    
        public Product(string id)
        {
            this.Id = id;
           
        }
    }
}
