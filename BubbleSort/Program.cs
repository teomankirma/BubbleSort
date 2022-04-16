using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"teo", "jack", "michael", "adam", "daniel"};

            BubbleSort.Sort(names);

            Console.Write("Bubble Sort");
            Console.WriteLine(" ");
            Console.WriteLine(string.Join(" | ", names));
        }
    }
}