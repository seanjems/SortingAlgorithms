using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)
                nums.Insert((int)(rnd.NextDouble() * 100));
            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During sorting: ");
            nums.SelectionSort();
            Console.WriteLine("After sorting: ");
            nums.DisplayElements();


        }
       
    }
}
