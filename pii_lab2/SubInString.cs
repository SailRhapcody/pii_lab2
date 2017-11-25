using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pii_lab2
{
    class SubInString : IFinder
    {

        public void find(String a, String b)
        {
            int j;
            for (int i = 0; i < a.Length - b.Length; i++)
            {
                for (j = 0; j < b.Length; j++)
                {
                    if (a[i] != b[j])
                    {
                        break;
                    }
                    else
                    {
                        i++;
                        if(i == a.Length)
                        {
                            break;
                        }
                    }
                }
                if (j == b.Length)
                {
                    Console.WriteLine("String {0} was founded in {1} at position {2}", b, a, i - b.Length);
                    break;
                }
                if (i + 1 == a.Length)
                {
                    Console.WriteLine("String {0} was not founded in {1}", b, a);
                }
            }
        }

        public void find(List<int> list, int value)
        {
            throw new NotImplementedException();
        }
    }
}
