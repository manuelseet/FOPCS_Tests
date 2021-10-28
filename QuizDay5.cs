using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCS_Tests
{
    class QuizDay5
    {
        static void Main(string[] arg)
        {
            int[,] theArray = new int[,]
            {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7}
            };

            int count = 0;

            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());
            DigitCounter(theArray, input);

        }

        public static void DigitCounter(int[,] arr, int i)
        {
            int rows = arr.GetLength(0); //get number of rows in array
            int col = arr.GetLength(1); //get number of col in array

            int count = 0; //prepare a counter variable

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (arr[r, c] == i)
                        count++;
                }


            }

            Console.WriteLine($"The number of {i} is {count}");
        }
    }
}
