using System;
using System.Security.Cryptography.X509Certificates;

namespace Challenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Error!");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Program Completed");
            }
        }
        public static int StartSequence()
        {
            Console.WriteLine("Please enter 3 numbers:");
            string nums = Console.ReadLine();
            int[] numberArray = ConvertStringToNumbers(nums);
            
            if (numberArray.Length < 3)
            {
                Console.WriteLine("0");
                return 0;
            }
            else
            {
                int product = ProductOfArray(numberArray);
                Console.WriteLine($"The product of these 3 numbers is: {product}");
                return product;
            } 
        }

        public static int[] ConvertStringToNumbers(string input)
        {
            string[] numsCut = input.Split(' ');
            int[] numberArray = Array.ConvertAll(numsCut, n => {
                return int.Parse(n);
            });
            return numberArray;
        }

        public static int ProductOfArray(int[] numberArray)
        {
            if (numberArray.Length < 3)
            {
                return 0;
            }
            else
            {
                return numberArray[0] * numberArray[1] * numberArray[2];
            }
            
        }
    }
}
