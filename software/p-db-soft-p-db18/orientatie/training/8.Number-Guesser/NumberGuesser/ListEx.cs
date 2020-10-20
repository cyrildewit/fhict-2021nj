using System;
using System.Collections.Generic;
public static class ListEx
{
    public static Tuple<int, int> BinarySearchWithCount<T>(
        this IList<T> list, T key)
    {
        int min = 0;
        int max = list.Count - 1;
        int counter = 0;

        while (min <= max)
        {
            counter++;
            int mid = (min + max) / 2;
            int comparison = Comparer<T>.Default.Compare(list[mid], key);
            if (comparison == 0)
            {
                return new Tuple<int, int>(mid, counter);
            }
            if (comparison < 0)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return new Tuple<int, int>(~min, counter);
    }
}