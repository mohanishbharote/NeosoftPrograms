using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public class SwapNumber
    {
    public void SwapTwoNumber(int x, int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }

    }
}
