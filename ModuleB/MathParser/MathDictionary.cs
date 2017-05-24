using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParser
{
    public static class MathDictionary
    {
        
        #region Operators 

        public static Dictionary<string, Func<double, double, double>> Operators
            => new Dictionary<string, Func<double, double, double>>()
            {
                {"+",Addition },
                {"-", Soustraction},
                {"*",Multiplication },
                {"/",Division},
                {"^",Pow},
                {"(",null },
                {")",null }
            };

        private static double Addition(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        private static double Soustraction(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        private static double Multiplication(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        private static double Division(double operand1, double operand2)
        {
            return operand1 / operand2;
        }

        private static double Pow(double operand1, double operand2)
        {
            return Math.Pow(operand1, operand2);
        }

        #endregion

        #region Maths Function

        public static Dictionary<string, Func<double, double>> Functions
            => new Dictionary<string, Func<double, double>>()
            {
                {"sin",Sin },
                {"cos",Cos },
                {"tg",Tg },
                {"ctg",Ctg },
                {"arcsin",Arcsin },
                {"arcos",Arccos },
                {"arctg",Arctg },
                {"arcctg",Arcctg },
                {"sinh",Sinh },
                {"cosh",Cosh },
                {"tgh",Tgh },
                {"ctgh",Ctgh },
                {"ln",Ln },
                {"log",Log },
                {"sqrt",Sqrt },
                {"abs",Abs },
                {"sign",Sign }

            };

        private static double Sin(double operand)
        {
            return Math.Sin(operand);
        }

        private static double Cos(double operand)
        {
            return Math.Cos(operand);
        }

        private static double Tg(double operand)
        {
            return Math.Tan(operand);
        }

        private static double Ctg(double operand)
        {
            return 1 / Math.Tan(operand);
        }

        private static double Arcsin(double operand)
        {
            return Math.Asin(operand);
        }

        private static double Arccos(double operand)
        {
            return Math.Acos(operand);
        }

        private static double Arctg(double operand)
        {
            return Math.Atan(operand);
        }

        private static double Arcctg(double operand)
        {
            return 1/Math.Atan(operand);
        }

        private static double Sinh(double operand)
        {
            return Math.Sinh(operand);
        }

        private static double Cosh(double operand)
        {
            return Math.Cosh(operand);
        }

        private static double Tgh(double operand)
        {
            return Math.Tanh(operand);
        }

        private static double Ctgh(double operand)
        {
            return 1 / Math.Tanh(operand);
        }

        private static double Ln(double operand)
        {
            return Math.Log(operand);
        }

        private static double Log(double operand)
        {
            return Math.Log10(operand);
        }

        private static double Sqrt(double operand)
        {
            return Math.Sqrt(operand);
        }

        private static double Abs(double operand)
        {
            return Math.Abs(operand);
        }

        private static double Sign(double operand)
        {
            return Math.Sign(operand);
        }
        #endregion

        #region Constant

        public static Dictionary<string,double> Constants => new Dictionary<string, double>()
        {
            {"e",Math.E },
            {"pi",Math.PI }
        };
        
        #endregion
    }
}
