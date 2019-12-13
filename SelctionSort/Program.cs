using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelctionSort
{
    // Summarry: Use Selction Sort to arrange random int list in order.
    // Author: David Krummen
    // Date: 10/06/2019
    class Program
    {
        static void Main(string[] args)
        {
            // Empty List
            List<int> Unordered = new List<int>();
            List<int> Ordered = new List<int>();


            // Instantiate Generate class and set Unordered to the RandomGenerator function
            Generate unorderedList = new Generate();
            Unordered = unorderedList.RandomGenerator();



            // Writeline for title of displayed list
            Console.WriteLine("Unordered:");

            // Display Unordered
            foreach (int i in Unordered)
            {
                // WriteLine Unordered numbers
                Console.Write(i + " ");
            }




            // Loop until Unordered count is 0
            for (int i = 0; i < Unordered.Count;)
            {
                // Minimum number in Unordered
                int min = Unordered.Min();


                // Add Unordered min int to ordered array
                Ordered.Add(min);

                // Remove current min from list
                Unordered.Remove(min);


                // If its the first run in the loop writeline for a header
                // No functionality, Just used for visual seperation
                if (Ordered.Count == 1)
                {
                    Console.WriteLine("\n" + "Ordered:");
                }


                // WriteLine Ordered Last number each loop 
                Console.Write(Ordered.Last() + " ");
            }

            Console.ReadKey();

        }
    }
}
