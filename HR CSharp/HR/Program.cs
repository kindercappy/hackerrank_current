using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = { 2, 4, 6, 8, 3 };
            insertionSort1(n, arr);
        }
        static void insertionSort1(int n, int[] arr)
        {
            // Complete this function
            int sortThis = arr[arr.Length - 1];
            arr[arr.Length - 1] = arr[arr.Length - 2];
            Console.WriteLine(string.Join(" ", arr));
            for (int i = arr.Length - 2; i >= 0; i -= 1)
            {
                if (arr[i] < sortThis)
                {
                    arr[i + 1] = sortThis;
                    Console.WriteLine(string.Join(" ", arr));
                }
                else if (arr[i - 1] > sortThis)
                {
                    arr[i] = arr[i - 1];
                    Console.WriteLine(string.Join(" ", arr));
                }
            }
            Console.ReadLine();
        }
    }
}
