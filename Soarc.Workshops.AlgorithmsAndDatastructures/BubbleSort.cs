using System;
using System.Collections.Generic;
using System.Text;

namespace Soarc.Workshops.AlgorithmsAndDatastructures
{
    public static class BubbleSort
    {
        public static void DoSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                        QuickSort.Swap(data, j, j + 1);
                }
            }
        }
    }
}
