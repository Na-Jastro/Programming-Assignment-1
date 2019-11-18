using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int first20SquareNumbers = 20;

            //Instatiating an Object of UnitOfWork Class
            UnitOfWork1 unitOfWork1 = new UnitOfWork1();
            List<int> lofNumbers = unitOfWork1.CalculateSquareNumbers(first20SquareNumbers);
            List<int> lofOddNumbers = unitOfWork1.GetOddNumbers(lofNumbers);
            List<int> lofEvenNumbers = unitOfWork1.GetEvenNumbers(lofNumbers);

            //get the total number of values in a list
            int AmountOfOddNumbers = (from x in lofOddNumbers select x).Count();
            int AmountOfEvenNumbers = (from x in lofEvenNumbers select x).Count();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total Amount Of Odd Numbers: {AmountOfOddNumbers} \nTotal Amount Of Even Numbers: {AmountOfEvenNumbers}");

            //Calculate the sum of all numbers in list
            int totalOddNumbers = (from x in lofOddNumbers select x).Sum(); 
            int totalEvenNumbers = (from x in lofEvenNumbers select x).Sum();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Sum Of all Odd Numbers: {totalOddNumbers} \nSum Of all Even Numbers: {totalEvenNumbers}");

            //Calculate the average of in a list
            double averageOddNumbers = (from x in lofOddNumbers select x).Average();
            double averageEvenNumbers = (from x in lofEvenNumbers select x).Average();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Average Of all Odd Numbers: {averageOddNumbers} \nAverage Of all Even Numbers: {averageEvenNumbers}");

            //get the minimum of in a list
            double MinimumOddNumbers = (from x in lofOddNumbers select x).Min();
            double MinimumEvenNumbers = (from x in lofEvenNumbers select x).Min();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Minimum Of all Odd Numbers: {MinimumOddNumbers} \nMinimum Of all Even Numbers: {MinimumEvenNumbers}");

            //get the Maximum of in a list
            double MaximumOddNumbers = (from x in lofOddNumbers select x).Max();
            double MaximumEvenNumbers = (from x in lofEvenNumbers select x).Max();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Maximum Of all Odd Numbers: {MaximumOddNumbers} \nMaximum Of all Even Numbers: {MaximumEvenNumbers}");

            Console.ReadLine();
        }
    }
}
