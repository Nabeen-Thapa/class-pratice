using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_pratice
{
    internal class _1_D_count_print
    {
        public static void Main(string[] args)
        {
            int[] arr = { 12, 2, 3, 6, 4, 10, 15, 8 };
            int count = arr.Length;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("here are " + count + " elements");
            Console.WriteLine("the sum of even is " + sum);
            Console.ReadKey();
        }
    }
}
