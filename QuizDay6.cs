using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Tests
{
    class QuizDay6
    {
        static void Main(string[] arg)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
                CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);

        }

        static int[] minIncomeArray = new int[]
            { 20000, 30000, 40000, 80000,
              120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
            { 0.02, 0.035, 0.07, 0.115,
              0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
            { 0, 200, 550, 3350,
              7950, 13950, 20750, 42350 };

        public static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            int income = Convert.ToInt32(Console.ReadLine());
            return income;
        }

        public static int GetTaxBracket(int income)
        {

            for(int i= minIncomeArray.Length-1; i>=0; i--) //remember about the highest index of the array
            {
                if (income > minIncomeArray[i])
                    return i;
            }
            return -1;


            
        }

        public static double CalculateIncomeTax(int income, int tb)
        {
            double tax = 0; //default value if income <20,000

            if (tb == -1)
                return tax;
            else
            {
                tax = ((income - minIncomeArray[tb]) * taxRateArray[tb]) +  basePayableAmountArray[tb];
                return tax;

            }

        }

        public static void PrintResult(int income, double taxPayable)
        {
            Console.WriteLine($"For taxable annual income of ${income: #,###,###.00}, the tax payable amount is ${taxPayable: #,###,###.00}");
        }
    }
}
