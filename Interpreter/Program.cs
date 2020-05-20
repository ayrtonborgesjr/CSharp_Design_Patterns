using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interpreter");
            Console.WriteLine();

            string roman = "MCMLXXIX";
            Context context = new Context(roman);

            List<Expression> expressions = new List<Expression>();
            expressions.Add(new ThousandsExpression());
            expressions.Add(new HundredsExpression());
            expressions.Add(new TensExpression());
            expressions.Add(new UnitsExpression());

            foreach (Expression exp in expressions)
            {
                exp.Interpreter(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            Console.ReadKey();
        }
    }
}
