

using DataStructuresAndAlgorithms.Helpers;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting.SelectionSort
{
    public static class SelectionSortAlgo
    {
        public static List<int> Sort(List<int> unsorted = null)
        {
            if(unsorted == null)
                unsorted = new List<int>() { 2,5,3,6,87,9,0,234,7 };

            // Print
            Printer<int>.PrintListToConsole(unsorted);
            Console.WriteLine("-------------");

            var sorted = new List<int>(unsorted.Count);


            for (int i = 0; i < unsorted.Count; i++)
            {
                var smallestI = FindSmallestIndex(unsorted);
                sorted.Add(unsorted[smallestI]);
                //swap
                unsorted[i] = unsorted[smallestI];
                unsorted[smallestI] = unsorted[i];
                

            }

            Printer<int>.PrintListToConsole(sorted);
            return sorted;
        }


        public static List<int> Sort2(List<int> unsorted = null)
        {
            if(unsorted == null)
                unsorted = new List<int>() { 2, 5, 3, 6, 87, 9, 0, 234, 7 };


            Printer<int>.PrintListToConsole(unsorted);
            Console.WriteLine("--------");

            for (int i = 0; i < unsorted.Count - 1; i++)
            {
                var smallestIndex = i;

                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    if (unsorted[j] < unsorted[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                // swap
                int temp = unsorted[smallestIndex];
                unsorted[smallestIndex] = unsorted[i];
                unsorted[i] = temp;
            }

            Printer<int>.PrintListToConsole(unsorted);

            return unsorted;
        }




        private static int FindSmallestIndex(List<int> list)
        {
            int smallest = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                    return i;
            }

            return 0;
        }
    }
}
