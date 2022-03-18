using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                StartSequence();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Welcome");
            }
        }
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Welcome to number game!, Let's do some math!");
                Console.WriteLine("Please enter a number greater than zero");
                int a = Convert.ToInt32(Console.ReadLine());
                int[] size = new int[a];
                int[] result = Populate(size);
                int sum = GetSum(result);
                int product = GetProduct(result, sum);
                   decimal quotient = GetQuotient(product);
                Console.WriteLine("Your arry is size " + size.Length);
                Console.WriteLine("The number in the array are: ");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + ",");
                }
                Console.WriteLine(" ");
                Console.WriteLine("The sum of the array is " + sum);
                 Console.WriteLine(sum + " * " + (product / sum) + " = " + product);
                 decimal division = Convert.ToDecimal(product) / quotient;
                 Console.WriteLine(product + " / " + division + " = " + quotient); 
            }
            catch (FormatException E)
            {
                Console.WriteLine($"{E.Message}");
            }
        }
        static int[] Populate(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {

                Console.WriteLine("Please enter number :" + (i + 1) + " of " + ar.Length );
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }

            return ar;
        }
        static int GetSum(int[] si)
        
            {
                int sum = 0;

                for (int i = 0; i < si.Length; i++)
                {
                    sum = sum+ si[i];
                }

                return sum;
            }

            static int GetProduct(int[] arr, int sum)
            {
            try
            {
                Console.WriteLine($"Please select a random number between 1 and {arr.Length}");
                int RandomNumber = Convert.ToInt32(Console.ReadLine());
                int product = sum * arr[(RandomNumber - 1)];
                return product;
            }
            catch (IndexOutOfRangeException indexE)
            {
                Console.WriteLine(indexE.Message);
                throw;
            }
        }
        static decimal GetQuotient(int prod)
        {
            try
            {
                Console.WriteLine($"Enter a number to divide the product {prod} by");
                decimal DivideBy = Convert.ToDecimal(Console.ReadLine());
                decimal quotient = decimal.Divide(prod,DivideBy);
                return quotient;
            }
            catch (DivideByZeroException divideByZeroE)
            {
                Console.WriteLine(divideByZeroE.Message);
                return 0;
            }
        }
    }
}
