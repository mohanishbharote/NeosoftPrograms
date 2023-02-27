using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public class PowerOfNumber
    {
        public long CalculatePowerOfNumber(int n, int p)
        {
            if (p!=0)
            {
                return (n * CalculatePowerOfNumber(n, p - 1));
            }
            return 1;
        }
    }
}
