using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace pii_lab2
{
    class SearchHandler
    {
        List<int> list;
        Stopwatch sw;

        public void start(int value, int searchType, int arrSize)
        {
            sw = new Stopwatch();
            list = new List<int>();
            arrFiller(arrSize);
            list[40] = 1245;
            sw.Start();
            switch (searchType)
            {
                case 0:
                    Console.Write("LinearSearch, ArrSize : {0}", arrSize);
                    LinearSearch ls = new LinearSearch();
                    ls.find(list, value);
                    break;
                case 1:
                    Console.Write("BinarySearch, ArrSize : {0}", arrSize);
                    BinarySearch bs = new BinarySearch();
                    bs.find(list, value);
                    break;
                case 2:
                    Console.Write("SubString");
                    SubInString ss = new SubInString();
                    ss.find("agsashatgfdhdhfdd", "sas4ha");
                    break;
            }
            sw.Stop();
            Console.WriteLine("; Time : " + sw.Elapsed.TotalMilliseconds * 1000000);
        }
        
        private void arrFiller(int arrSize)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrSize; i++)
            {
                list.Add(rnd.Next(1, 100));
            }
        }
    }
}
