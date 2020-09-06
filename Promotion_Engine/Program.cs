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
            try
            {
                List<Product> products = new List<Product>();
                Console.WriteLine("Enter total number of order");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("Enter the type of product:A,B,C or D");
                    string type = Console.ReadLine();
                    Product p = new Product(type);
                    products.Add(p);
                }

                int totalPrice = GetTotalPrice(products);
                Console.WriteLine(totalPrice);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

                }
                int ToatalPriceA = (CounterA / 3) * 130 + (CounterA % 3 * PriceA);
                int ToatalPriceB = (CounterB / 2) * 45 + (CounterA % 2 * PriceB);
                int ToatalPriceCD = 0;
                int ToatalPriceC = 0;
                int ToatalPriceD = 0;
                int DifferenceCountCD = 0;
                if (CounterC > 0 && CounterD > 0)
                {
                    DifferenceCountCD = CounterC - CounterD;
                    if (CounterC > CounterD)
                    {
                        DifferenceCountCD = CounterC - CounterD;
                        ToatalPriceCD = DifferenceCountCD * 30 + CounterC * PriceC;

                    }
                    else if (CounterD > CounterC)
                    {
                        DifferenceCountCD = CounterD - CounterC;
                        ToatalPriceCD = DifferenceCountCD * 30 + CounterD * PriceD;

                    }
                    else if (DifferenceCountCD == 0)
                    {
                        ToatalPriceCD = CounterC * 30;
                    }

                }
                else
                {
                    ToatalPriceC = (CounterC * PriceC);
                    ToatalPriceD = (CounterD * PriceD);
                }

            
            
            return ToatalPriceA + ToatalPriceB + ToatalPriceCD + ToatalPriceC + ToatalPriceD;
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
