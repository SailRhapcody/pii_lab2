using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pii_lab2
{
    class LinearSearch : IFinder
    {
        public void find(List<int> list, int value)
        {
            for(int i = 0;i < list.Count; i++)
            {
                if(list[i] == value)
                {
                    Console.Write("; Element {0} was found at {1} position", value, i);
                    break;
                }
                if(i + 1 == list.Count)
                {
                    Console.Write("; Element {0} was not found in array", value);
                }
            }
        }

    }
}
