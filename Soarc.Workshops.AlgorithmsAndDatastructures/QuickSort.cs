using System;
using System.Collections.Generic;
using System.Text;

namespace Soarc.Workshops.AlgorithmsAndDatastructures
{
    public static class QuickSort
    {
        public static void DoSort(int[] data)
        {
            DoQuickSort(data, 0, data.Length - 1);
        }
        static void DoQuickSort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var num = a[start];

            var i = start - 1;
            var j = end + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (a[i] < num);

                do
                {
                    j--;
                } while (a[j] > num);

                if (i >= j)
                    break;

                Swap(a, i, j);
            }

            //a[i] = num;
            DoQuickSort(a, start, j);
            DoQuickSort(a, j + 1, end);
        }

        public static void Swap(int[] a, int i, int j)
        {
            if (i == j)
                return;

            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
