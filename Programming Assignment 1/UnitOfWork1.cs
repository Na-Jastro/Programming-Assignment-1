using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment_1
{
    public class UnitOfWork1
    {
        /// <summary>
        /// Calculate Square Numbers and add to List
        /// </summary>
        /// <param name="squareNumber"></param>
        /// <returns></returns>
        public List<int> CalculateSquareNumbers(int squareNumber)
        {
            List<int> lofSquareNumbers = new List<int>();
            for (int y = 1; y <= squareNumber; y++)
            {
                lofSquareNumbers.Add(Convert.ToInt32(Math.Pow(y, 2)));
            }
            return lofSquareNumbers;
        }
        /// <summary>
        /// Get all Even Numbers from a List
        /// </summary>
        /// <param name="evenNumbers"></param>
        /// <returns></returns>
        public List<int> GetEvenNumbers(List<int> evenNumbers)
        {
            List<int> lofEvenNumbers = new List<int>();
            foreach (var num in evenNumbers)
            {
                if(Convert.ToInt32(num.ToString()) % 2 == 0)
                {
                    lofEvenNumbers.Add(Convert.ToInt32(num.ToString()));
                }
            }
            return lofEvenNumbers;
        }
        /// <summary>
        /// Get All Odd Numbers from a list
        /// </summary>
        /// <param name="oddNumbers"></param>
        /// <returns></returns>
        public List<int> GetOddNumbers(List<int> oddNumbers)
        {
            List<int> lofOddNumbers = new List<int>();
            foreach (var num in oddNumbers)
            {
                if (Convert.ToInt32(num.ToString()) % 2 != 0)
                {
                    lofOddNumbers.Add(Convert.ToInt32(num.ToString()));
                }
            }
            return lofOddNumbers;
        }
    }
}
