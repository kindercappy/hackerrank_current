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
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = { 99, 0, 99, 100, 4, 12, 123, 2, 3, 1, 3, 1232 };
            //int[] arr = { 2, 10, 3, 7, 9, 4, 6, 12, 8 };

            int[] result = CountingSort(arr);
            Console.WriteLine(String.Join(" ", result));
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
            int center = (int)Math.Round(mid);
            for (int i = 0; i < arr.Length; i += 1)
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
        private static int[] QuickSort(int[] arr)
        {
            int[] sorted = new int[arr.Length];
            int[] pivot = new int[] { arr[0] };
            int[] left = new int[0];
            int[] right = new int[0];
            int insertLeft = 0;
            int insertRight = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < pivot[0])
                {
                    if (insertLeft == left.Length) Array.Resize(ref left, left.Length+1);
                    left[insertLeft] = arr[i];
                    insertLeft++;
                }
                else if (arr[i] > pivot[0])
                {
                    if (insertRight == right.Length) Array.Resize(ref right, right.Length+1);
                    right[insertRight] = arr[i];
                    insertRight++;
                }
            }
            left = left.Concat(pivot).ToArray();
            sorted = left.Concat(right).ToArray();
            return sorted;
        }
        private static int[] CountingSort(int[] arr)
        {
            int[] result = new int[100];
            for (int i = 0; i < 100; i++)
            {
                int num = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i==arr[j])num++;
                }
                result[i] = num;
            }
            return result;
        }
    }
}
