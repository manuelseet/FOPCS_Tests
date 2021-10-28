using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Tests
{
    class QuizDay4
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to ISS BANK");
            PINChecker();


        }

        public static void PINChecker()
        {                
            
            string myPIN = "123456";
            string uPIN = "";
            for (int i = 1; i<= 3; i++)
            {                
                Console.Write("Enter your PIN: ");
                string uPin = Console.ReadLine();
                Console.WriteLine();

                if (uPin != myPIN)
                {
                    if (i < 3)
                    {
                        Console.WriteLine("Incorrect PIN ");
                        continue;
                    }

                    else if (i == 3)
                        Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                }
                else
                {
                    Console.WriteLine("Pin accepted, you can access your account now");
                    break;

                }
                   

            }


 
            


        }
    }
}
