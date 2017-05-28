using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorCore;

namespace RunMathParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put Math expression : ");
            var expression = Console.ReadLine();
            Console.WriteLine($"Resulte: {MathParser.MathParser.Parse(expression)}");
            Console.Read();

            var vector1 = new Vector<int>(1,1);
            var vector2 = new Vector<int>(-1,1);
            var vector3 = new Vector<int>(2,2);

            Console.WriteLine(vector1 + vector2);
            Console.WriteLine($"Are Colineare Vector 1 and Vector 3 = {Vector<int>.AreColiniare(vector1, vector3)}");
            Console.WriteLine($"Are Orthogonals vector 1 and vector 2 {Vector<int>.AreOthogonal(vector1,vector2)}");
            Console.WriteLine($"factoria 5 {StackFactorial(5)}");
        }

        private static int StackFactorial(int n)
        {
           var stack = new Stack<int>();
            if(n!=0)
            stack.Push(n);
            stack.Push(stack.Pop() * (n - 1));
            StackFactorial(n - 1);
            return stack.Pop();
        }
    }
}
