using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    internal class LinearFunction : Function
    {
        public double K {  get; set; }
        public double B { get; set; }

        public LinearFunction(double lowerBound, double upperBound, double k, double b) 
            :base(lowerBound, upperBound, "Линейная функция")
        {
            K = k;
            B = b;
        }
        public override double Fun(double x)
        {
            base.Fun(x);
            return K* x +B;
        }
    }
}
