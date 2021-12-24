using System;

namespace Product_every_other_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Product(arr);
            Console.WriteLine("Hello World!");
        }

        public static void Product(int[] arr)
        {
            int len = arr.Length;
            int[] res = new int[len];
            int[] left = new int[len];
            int[] right = new int[len];
            right[len - 1] = 1;
            left[0] = 1;

            for (int i = 1; i < len; i++)
            {
                left[i] = left[i - 1] * arr[i-1];
            }

            for (int i = len-2; i >=0; i--)
            {
                right[i] = right[i + 1] * arr[i+1];
            }

            for (int i = 0; i < len; i++)
            {
                

                res[i] = right[i] * left[i];
            }

            Console.WriteLine(string.Join(",", res));
        }
    }
}
