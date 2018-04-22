using System;
using System.Collections.Generic;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            string welcomeMessage = "Let's divide some numbers! Pick a number: ";
            Console.WriteLine(welcomeMessage);

            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                int numOne = 200;
                int quotOne = numOne / input;
                int numTwo = 400;
                int quotTwo = numTwo / input;
                int numThree = 600;
                int quotThree = numThree / input;
                int numFour = 800;
                int quotFour = numFour / input;
                List<int> quotients = new List<int> { quotOne, quotTwo, quotThree, quotFour };

                Console.WriteLine("Results: ");

                foreach (int quotient in quotients)
                {
                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number only.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }

        }
    }
}
