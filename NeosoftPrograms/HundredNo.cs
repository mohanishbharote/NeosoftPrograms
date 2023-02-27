using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public class HundredNo
    {
        public void ValaeMurgghulisNo() 
        {
            int counter = 1;
            while (counter <= 100)
            {
                if (counter % 3 == 0)
                    Console.WriteLine("valar");
                else if (counter % 5 == 0)
                    Console.WriteLine("morghulis");
                else if (counter % 5 == 0 && counter % 3 == 0)
                    Console.WriteLine("valar morghulis");
                else Console.WriteLine(counter);
                counter++;
            }
        }
    }
}
