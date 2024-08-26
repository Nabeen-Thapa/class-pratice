using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_pratice
{
    internal class _1_D_sort
    {
        public static void Main(string[] args)
        {

            int[] arr = { 12, 2, 3, 6, 4, 10, 15, 8 };
            int i = 0;
            for ( i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
                Console.WriteLine(arr[i]);

            Console.ReadKey();
        }
    }
}
