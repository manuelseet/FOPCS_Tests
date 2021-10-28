using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Tests
{
    class QuizDay2
    {
        static void Main(string[] arg)
        {
            Console.Write("Please enter the length in cm: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double inches = ConvertToInch(cm);
            Console.WriteLine($"{inches: #.000}");
        }

        public static double ConvertToInch(double len)
        {
            return len / 2.54;
        }

    }
}
