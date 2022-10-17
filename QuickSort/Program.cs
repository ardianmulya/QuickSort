using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("enter the number of elements in the arrray :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements\n");
            }
            Console.WriteLine("\n====================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n====================")
        }
        static void Main(string[] args)
        {
        }
    }
}
