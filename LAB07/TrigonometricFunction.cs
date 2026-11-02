using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    internal class TrigonometricFunction : Function
    {
        public TrigonometricFunction(double lowerBound, double upperBound) 
            : base(lowerBound, upperBound, "Тригонометрическая функция")
        {
        }
        public override double Fun(double x)
        {
            base.Fun(x);
            return Math.Sin(x);
        }
        public override string ToString()
        {
            string result = $"Function(x) [{LowerBound}; {UpperBound}] = ";

            int Low = (int)Math.Ceiling(LowerBound);
            int Up = (int)Math.Floor(UpperBound);

            for (int i = Low; i <= Up; i++)
            {
                result += $"f({i})={Fun(i):F4}, ";
            }
            return result;
        }
    }
}
