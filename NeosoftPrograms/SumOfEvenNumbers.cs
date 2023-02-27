using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public class SumOfEvenNumbers
    {
        public int Sum(int[] number) {

            
            int even = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    even += number[i];
                }
            }
            return even;
        }
    }
}
