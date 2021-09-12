using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class D3
    {
        static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
           
            int s = 0;
            for (int i = 0; i <5; i++)
            {
                if (i == 0)
                {
                    s += x + 1;

                }

                if(i == 1 || i == 2)
                {
                    s = s * (x + 2) + (x + 2);
                    if (i == 2)
                    {
                        x += 1;
                    }
                }

                if (i == 3)
                {
                    s = s * (x + 2) + (x + 2);
                    x += 1;
                }
                if (i == 4)
                {
                    s = s * (x + 2) + (x + 2);

                }
            }    
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
