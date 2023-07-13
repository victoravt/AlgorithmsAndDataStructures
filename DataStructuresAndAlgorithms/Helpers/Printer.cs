

namespace DataStructuresAndAlgorithms.Helpers
{
    public static class Printer<T>
    {
        public static void PrintListToConsole(IEnumerable<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
