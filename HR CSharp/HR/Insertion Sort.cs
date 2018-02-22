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
            int[] arr = { 1, 0, 5, 7, 4, 12 };
            CorrectnessAndTheLoopInvariant(arr);
            Console.ReadLine();
        }
        public static void InsertionSort1(int n, int[] arr)
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
        static void InsertionSort2(int n, int[] arr)
        {
            // Complete this function
            for (int i = 1; i < arr.Length; i += 1)
            {
                int putBackIndex = 0;

                while (i > putBackIndex)
                {
                    if (arr[i] < arr[putBackIndex])
                    {
                        int putBack = arr[i];
                        int putFront = arr[putBackIndex];
                        arr[i] = putFront;
                        arr[putBackIndex] = putBack;
                    }
                    putBackIndex += 1;
                }
            Console.WriteLine(string.Join(" ", arr));
            }
            Console.ReadLine();
        }

        private static int IntroTutorial(int V, int[] arr)
        {
            // Complete this function
            int result = 0;
            double mid = arr.Length / 2;
            int center =(int) Math.Round(mid);
            for(int i =0; i < arr.Length; i += 1)
            {
                if (arr[i] == V)
                {
                    return i;
                }
            }
            return result;
        }

        private static void CorrectnessAndTheLoopInvariant(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}
