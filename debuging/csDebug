using System;
using System.Collections.Generic;
using System.Data;

namespace Linear_Sort
{
    class Program
    {
        public static List<int> numbersToSort = new List<int>();

        static void Main(string[] args)
        {
            sortList();
        }

        static void sortList()
        {
            // create sorted numbers 
            generateList(10000);

            // begin sorting numbers
            Console.WriteLine("Sorting numbers...");

            List<int> sortedList = new List<int>();

            // set the previous lowest to close to infinity
            int previousLowest = -1;
            int currentLowest = 999999999;
            int iteration = 0;

            int lowestPos = 0;
            List<int> usedPositions = new List<int>();

            while (iteration < numbersToSort.Count)
            {
                int pos = 0;

                foreach (int num in numbersToSort)
                {
                    if (((num > previousLowest) || (num >= previousLowest && !usedPositions.Contains(pos))) && num < currentLowest)
                    {
                        currentLowest = num;
                        lowestPos = pos;
                    }
                    pos++;
                }

                if (currentLowest != 999999999)
                {
                    sortedList.Add(currentLowest);
                    Console.Write(currentLowest + ", ");
                    previousLowest = currentLowest;
                    usedPositions.Add(lowestPos);
                }
                currentLowest = 999999999;
                iteration++;
            }
        }

        public static void readList(List<int> listToRead, string sep)
        {
            foreach (int numToRead in listToRead)
            {
                Console.Write(numToRead.ToString() + sep);
            }
            Console.WriteLine("");
        }

        static void generateList(int numbers)
        {
            int i = 0;

            Random rand = new Random();
            while (i < numbers)
            {
                int num = rand.Next(1, 100);
                Console.Write(num.ToString() + ",");
                numbersToSort.Add(num);
                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
