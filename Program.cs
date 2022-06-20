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
            Console.WriteLine();
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
            for (int i = 0; i < arrayToSort.Length-1; i++){
                int itemToSort = arrayToSort[i+1];
                
            }
        }
    }
}

