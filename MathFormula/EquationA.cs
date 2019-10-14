using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormula
{
    class EquationA
    {
        public double MathA(float x)
        {
            double reresult = x * 2;
            double result = Math.Pow(x, 2) + reresult - 7;
            return result;
        }

        public double MathBA(float a, float b, float c)
        {
            double result = -b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            
            double Result = result / 2 * a;
            
            return Result;
        }

        public double MathBB(float a, float b, float c)
        {
            double result = -b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            double Result = result / 2 * a;
            return Result;
        }

        public double MathC(float s, float e, float t)
        {
            double result = e - s;
            double Result = s + t * result;
            return Result;
        }

        public double MathD(float x1, float x2, float y1, float y2)
        {
            double result = x2 - x1;
            double reresult = y2 - y1;
            double Result = Math.Sqrt(Math.Pow(result, 2) + Math.Pow(reresult, 2));
            return Result;
        }

        public double MathE()
        {

        }
    }
}