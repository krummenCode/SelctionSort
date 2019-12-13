using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelctionSort
{
    public class Generate
    {
        public List<int> RandomGenerator()
        {
            List<int> randomList = new List<int>();

            // Number count of randomList
            int ListSize = 100;

            // Random Class
            Random randomInt = new Random();


            // Add random numbers to randomList
            for (int i = 0; i < ListSize; i++)
            {
                // int range
                int random = randomInt.Next(1,100);
                randomList.Add(random);
            }

            return randomList;
        }

    }
}
