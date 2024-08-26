using System;
namespace class_pratice
{
    internal class minmax
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter he size of array:");
            int size = int.Parse(Console.ReadLine());
            int []array = new int[size];
          
            Console.WriteLine("enter hte array elements:");
            for (int i = 0; i < size; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
                int min = array[0];
                int max = array[0];
                for (i = 0; i < array.Length; ++i)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                    if (max<array[i]) 
                    {
                        max=array[i];
                    }
                }
                Console.WriteLine("min is: " + min);
                Console.WriteLine("max is: " + max);
             }
            Console.ReadKey();
        }
    }
}
