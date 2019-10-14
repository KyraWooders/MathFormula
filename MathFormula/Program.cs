using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0.00f;
            float a = 0.00f;
            float b = 0.00f;
            float c = 0.00f;
            float s = 0.00f;
            float e = 0.00f;
            float t = 0.00f;
            float x1 = 0.00f;
            float x2 = 0.00f;
            float y1 = 0.00f;
            float y2 = 0.00f;

            EquationA Meth = new EquationA();

            Console.WriteLine(Meth.MathA(x));
            Console.WriteLine(Meth.MathBA(a, b, c));
            Console.WriteLine(Meth.MathBB(a, b, c));
            Console.WriteLine(Meth.MathC(s, e, t));
            Console.WriteLine(Meth.MathD(x1, x2, y1, y2));

            Console.ReadLine();
        }
        

    }
}
