using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__co_ban2
{
    internal class buoi1
    {
        static void Main(string[] args)
        {
            int n = 873;
            int tram = n / 100;
            int chuc = n / 10;
            int donvi = n % 10;
            Console.WriteLine(tram);
            Console.WriteLine( donvi );

        }
    }
}
