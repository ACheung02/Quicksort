using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* I have used google to help for this as I wasn't too familiar with quicksort prior to this so I also watched a video as well 
 - but I have tried to work through the code backwards in order to see how it functions */
namespace Quicksort
{
    class Program
    {
        private static void Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quicksort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quicksort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("List: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quicksort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted List: ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
