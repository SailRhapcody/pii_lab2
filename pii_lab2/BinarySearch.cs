using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pii_lab2
{
    class BinarySearch : IFinder
    {
        public void find(List<int> list, int value)
        {
            list.Sort();
            int left = 0, right = list.Count - 1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if(value == list[mid])
                {
                    Console.Write("; Element {0} was found at {1} position", value, mid);
                    break;
                }
                if(value > list[mid])
                {
                    left = mid + 1;
                }
                else if(value < list[mid])
                {
                    right = mid - 1;
                }
            }
            if(left > right)
            {
                Console.Write("; Element {0} was not found", value);
            }
        }
    }
}
