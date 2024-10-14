using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(x => x % 2 == 0); // Query defined, not executed

            numbers.AddRange(new int[] { 6, 7 }); // Modifying the collection before execution

            foreach (var number in evenNumbers) // (evenNumbers) will use last (numbers) 
            {
                Console.WriteLine(number); // Outputs: 2, 4, 6 (because the data source changed)
            }

        }
    }
}
