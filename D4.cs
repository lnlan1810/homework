using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class D4
    {
        static void Main()
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            float d = (float)(a+b+c) / 3;
            int e = a * b * c;
            float h;
            if (d < e)
            {
                h = d;
            }
            else { h = e; }
            float y = h / (1 + h * h);

            Console.WriteLine(y);
            Console.ReadLine();
        }

    }
}
