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
                Console.WriteLine("Program Complete");

            }

        }
        public static int StartSequence()
        {
            Console.WriteLine("Please enter 3 numbers:");
            string numbers = Console.ReadLine();
            string[] numbersCut = numbers.Split(' ');
            int[] numberArray = Array.ConvertAll(numbersCut, n => int.Parse(n));

            if (numberArray.Length < 3)
            {
                Console.WriteLine("0");
                return 0;

            }
            else
            {
                int number1 = numberArray[0];
                int number2 = numberArray[1];
                int number3 = numberArray[2];
                int product = number1 * number2 * number3;
                Console.WriteLine($"The product of these 3 numbers is: {product}");
                return product;

            }

                      
        }
        public static void Random()
        {
            Console.WriteLine("Please enter a number between 2-10");
            string randomNumbers = Console.ReadLine();

        }
    }

}
        
    

