using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeCounter;
using VectorCore;

namespace RunMathParser
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MathParser

            Console.WriteLine("Put Math expression : ");
            var expression = Console.ReadLine();
            Console.WriteLine($"Resulte: {MathParser.MathParser.Parse(expression)}");
            Console.Read();
            #endregion

            #region Vector
            var vector1 = new Vector<int>(1, 1);
            var vector2 = new Vector<int>(-1, 1);
            var vector3 = new Vector<int>(2, 2);

            Console.WriteLine(vector1 + vector2);
            Console.WriteLine($"Are Colineare Vector 1 and Vector 3 = {Vector<int>.AreColiniare(vector1, vector3)}");
            Console.WriteLine($"Are Orthogonals vector 1 and vector 2 {Vector<int>.AreOthogonal(vector1, vector2)}");
            #endregion

            #region Factorial
            Console.WriteLine($"factoria 5 {Factorial(5)}");
            #endregion

            #region AgeCalculator

            var a = DateTime.Parse("02.06.1993").Age();
            Console.Write(a);
            Console.Read();

            #endregion



        }

        // ReSharper disable once FunctionRecursiveOnAllPaths
        private static int Factorial(int n)
        {
            var stack = new Stack<int>();
            if (n != 0)
                stack.Push(n);
            stack.Push(stack.Pop() * (n - 1));
            Factorial(n - 1);
            return stack.Pop();

        }
    }
}
