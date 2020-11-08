using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class SortArrayOfStingNumeric
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string[] unsorted = new string[n];

            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted[i] = unsortedItem;
            }

            string[] result = SortArrayOfStingNumeric.bigSorting(unsorted);

            Console.WriteLine("\n" + "Sorted array" );
            Console.WriteLine(string.Join("\n", result));
            Console.ReadLine();

            //textWriter.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }

        static string[] bigSorting(string[] unsorted)
        {
            /*
            Array.Sort(unsorted, (s1, s2) =>
            {
                int l = s1.Length - s2.Length;
                return (l != 0) ? l : string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
            });
            */

            Array.Sort(unsorted, new StringComparer());
            return unsorted;
        } 
    }

    public class StringComparer : IComparer<string>
    {      
        public int Compare(string s1, string s2)
        {
            int l = s1.Length - s2.Length;
            return (l != 0) ? l : string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
        }
    }
}
