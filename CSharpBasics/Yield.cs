using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class YieldDemo
    {
        public static void Main()
        {
            foreach (int i in Power(2,10))
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Compute the power of the number up to the exponent
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns></returns>
        public static IEnumerable<int> Power(int number, int exponent)
        {
            try
            {
                int result = 1;
                for (int i = 1; i <= exponent; i++)
                {
                    result = result * number;
                    //result = result / (i-1);
                    yield return result;
                }
            }
            //catch (Exception ex)
            //{

            //}
            finally
            {

            }
        }
    }

}
