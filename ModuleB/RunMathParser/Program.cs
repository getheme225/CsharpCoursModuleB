using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
