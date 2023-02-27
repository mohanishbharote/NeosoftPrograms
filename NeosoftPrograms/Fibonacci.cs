using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeosoftPrograms
{
    public class Fibonacci
    {
        public int FindFibonacciNumber(int n)
        {
            int firstNumber = 0, answer = 1, nextNumber = 0;
            // To return the first Fibonacci number  
            if (n-1 == 0)
                return firstNumber;
            for (int i = 2; i <= n-1; i++)
            {
                nextNumber = firstNumber + answer;
                firstNumber = answer;
                answer = nextNumber;
            }
            return answer;

        }
    }
}
