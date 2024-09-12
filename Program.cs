using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int rows = int.Parse(Console.ReadLine());
            List<int> currentRow = new List<int>();
            double sum = 0;

            Console.WriteLine("Enter list elements:");
            for (int i = 0; i < rows; i++)
            {
                currentRow = Console.ReadLine().Split().Select(int.Parse).ToList();
                foreach (int item in currentRow)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
