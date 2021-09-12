using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int u = x * x;
            int v = u * x;
            int w = v * u;

            double y = (w + 5.7 * v) / (u - 7.5) + 4.2 * w - 8.9 * u;
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
