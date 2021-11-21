using System;
using System.Collections.Generic;
using System.Data;

namespace Linear_Sort
{
    class Program
    {
        void sortList(List<int> numbersToSort)
        {
            List<int> sortedList = new List<int>();
            
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
                    previousLowest = currentLowest;
                    usedPositions.Add(lowestPos);
                }
                currentLowest = 999999999;
                iteration++;
            }
        }
    }
}
