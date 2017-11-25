using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pii_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchHandler sh = new SearchHandler();
            sh.start(1245, 0, 100);
            sh.start(1245, 1, 100);
        }
    }
}
