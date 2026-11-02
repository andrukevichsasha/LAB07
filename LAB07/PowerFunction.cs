using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    internal class PowerFunction : Function
    {
        public int N {  get; set; }

        public PowerFunction(double lowerbound, double upperbound, int n) 
            :base(lowerbound, upperbound, "Степенная функция")
        {
            N = n;
        }
        public override double Fun(double x)
        {
            base.Fun(x);
            return Math.Pow(x, N);
        }
    }
}
