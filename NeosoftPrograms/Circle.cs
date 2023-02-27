using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public sealed class circle 
    {
        private double radius;
        public double calculate(Func<double, double> op)
        {
            return op(radius);
        
        }
    }
}
