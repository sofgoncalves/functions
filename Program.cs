using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = { 1, 5, 2, 4, 7};
            InsertionSort(arrayToSort); 
            
        }
        static void BubbleSort(int[] arrayToSort)
        {
            for(int pass = 1; pass)
        }
        static void PrintList(int[]list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void InsertionSort(int[] arrayToSort)
        {
            for (int i = 0; i < arrayToSort.Length-1; i++)
            {
                int itemToSort = arrayToSort[i+1];
                for (int j = i; j >= 0; j--)
                {
                    if (j > 0 && itemToSort >= arrayToSort[j - 1])
                    {
                        arrayToSort[j] = itemToSort;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

