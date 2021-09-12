using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class D5
    {
        static void Main(string[] args)
        {
            int n;
            int k = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            if (k == l)
            {
                 n = t;
            }
            if(k == t)
            {
                 n = l;
            }
            else
            {
                 n = k;
            }
            Console.WriteLine("n =" + n);
            Console.ReadLine();
        }
    }
}
