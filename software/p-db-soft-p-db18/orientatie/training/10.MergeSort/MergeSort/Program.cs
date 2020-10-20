using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputSplitted = input.Split(' ');

            int[] numbers = Array.ConvertAll(inputSplitted, int.Parse);

            Console.Write("Initial array is: ");
            foreach (int v in numbers)
            {
                Console.Write(v + " ");
            }

            List<int> result = Program.MergeSort(numbers.OfType<int>().ToList());
            
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            int n = unsorted.Count;

            if (n <= 1)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();


            int middle = n / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < n; i++)
            {
                right.Add(unsorted[i]);
            }

            left = Program.MergeSort(left);
            right = Program.MergeSort(right);

            return Program.Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Any() && right.Any())
            {
                if (left.First() <= right.First())
                {

                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            while (left.Any())
            {
                result.Add(left.First());
                left.Remove(left.First());
            }

            while (right.Any())
            {
                result.Add(right.First());
                right.Remove(right.First());
            }

            return result;
        }
    }
}
