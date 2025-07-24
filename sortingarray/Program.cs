using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 30, 10, 50, 20, 40 };
            Array.Sort(numbers);
            Console.WriteLine("Sorted array in ascending order:");
            for(int i=0;i<numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}
