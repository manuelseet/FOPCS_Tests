using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Tests
{
    class QuizDay3
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to the ISS Gadget Shop!");
            Console.Write("Number of items to purchase: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Please pay {issShop(numb).ToString("C2")}");
        }

        public static double issShop(int n)
        {
            double unitPrice = 500;
            double rawPrice = unitPrice * n;
            double finalPrice = rawPrice;

            if (rawPrice > 2000 && rawPrice <= 3000)
                finalPrice = rawPrice * 0.97;
            else if (rawPrice > 3000 && rawPrice < 6000)
                finalPrice = rawPrice * 0.95;
            else if (rawPrice > 6000)
                finalPrice = rawPrice * 0.92;

            return finalPrice;
            

        }
    }
}
