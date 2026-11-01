using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    internal class Function
    {
        public double LowerBound{get; set;}
        public double UpperBound{get; set;}
        public string FunctionName {get; set;}
        public Function(double lowerBound, double upperBound, string functionName)
        {
            LowerBound = lowerBound;
            UpperBound = upperBound;
            FunctionName = functionName;
        }

        public virtual double Fun(double x)
        {
            if (x >= LowerBound && x <= UpperBound)
            {
                return x;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"x={x} должен принадлежать отрезку [{LowerBound}; {UpperBound}]");
            }
        }
        public override string ToString()
        {
            string result = $"Function(x) [{LowerBound}; {UpperBound} = ";

            int Low = (int)Math.Ceiling(LowerBound);
            int Up = (int)Math.Floor(UpperBound);

            for(int i = Low; i <= Up; i++)
            {
                result += $"f(x)={Fun(i)}, ";
            }
            return result ;
        }
    }
}
