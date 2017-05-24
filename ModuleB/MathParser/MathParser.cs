using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathParser
{
    public  class MathParser
    {
        private static string PrepareString(string expression)
        {
            expression = expression.Replace(" ", String.Empty);
            expression = expression.Replace(',', '.');
            return expression;
        }

        private static List<Token> GetTokens(string expression)
        {
            List<Token> tokens = new List<Token>();
            var isError = false;
            var number = "";
            var function = "";
            var constant = "";
            foreach (var a in expression)
            {
                if (IsNumbersOrComma(a,ref number, tokens)) continue;
                if (IsOperator(a, tokens)) continue;
                constant += a;
                function += a;
                if ((Isfunction(ref function, tokens))^(IsConstant(ref constant, tokens))) continue;
                
            }
            if(number!="") tokens.Add(new Token(number,TokenType.Number));
            
            return tokens;
        }

        private static bool IsUnaryOperator(List<Token> pTokens)        
        {
            if (pTokens == null || pTokens.Capacity == 0)
            {
                return true;
            }

            else
            {
                var token = pTokens[pTokens.Count - 1];
                return token.Lexeme == "(";
            }
        }

        private static bool IsNumbersOrComma(char a,ref string number,List<Token> tokens)
        {
            if (!(char.IsDigit(a) || a == '.'))
            {
                if (number == "") return false;
                tokens.Add(new Token(number, TokenType.Number)); number = "";
                return false;
            }
           
            number += a.ToString(CultureInfo.InvariantCulture);
            return true;
        }

        private static bool IsOperator(char a, List<Token> tokens)
        {
            if (!MathDictionary.Operators.ContainsKey(a.ToString(CultureInfo.InvariantCulture))) return false;
            tokens.Add(IsUnaryOperator(tokens)
                ? new Token("0", TokenType.Number)
                : new Token(a.ToString(CultureInfo.InvariantCulture), TokenType.Operator));
            return true;
        }

        private static bool Isfunction(ref string function, List<Token> tokens)
        {
            if (!MathDictionary.Functions.ContainsKey(function)) return false;
            tokens.Add(new Token(function, TokenType.Function));
            function = "";
            return true;
        }

        private static bool IsConstant(ref string constant, List<Token> tokens)
        {
            if (!MathDictionary.Constants.ContainsKey(constant)) return false;
            tokens.Add(new Token(constant,TokenType.Constant));
            constant = "";
            return true;
        }

        private static List<Token> ConvertToReversePolishNotation(List<Token> tokens)
        {
            var reversePolishNotation = new List<Token>();
            var stack = new Stack();
            foreach (var t in tokens)
            {
                switch (t.Type)
                {
                    case TokenType.Number:
                    case TokenType.Constant:
                        reversePolishNotation.Add(t);
                        break;
                    case TokenType.Function:
                        stack.Push(t);
                        break;
                    default:
                        if (t.Lexeme == "(")
                        {
                            stack.Push(t);
                        }
                        else if (t.Type == TokenType.Operator && t.Lexeme != ")")
                        {
                            if (!stack.Empty())
                            {
                                while (stack.Top().Type == TokenType.Operator && t.Priority <= stack.Top().Priority)
                                {
                                    reversePolishNotation.Add(stack.Pop());
                                    if (stack.Empty()) break;
                                }
                                stack.Push(t);
                            }
                            else
                            {
                                stack.Push(t);
                            }
                        }
                        else if (t.Type == TokenType.Operator && t.Lexeme == ")" && !stack.Empty())
                        {
                            while (stack.Top().Lexeme != "(")
                            {
                                reversePolishNotation.Add(stack.Pop());
                                if (stack.Empty()) break;
                            }
                            stack.Pop();
                            if (stack.Empty()) continue;
                            if (stack.Top().Type == TokenType.Function)
                            {
                                reversePolishNotation.Add(stack.Pop());
                            }
                        }
                        break;
                }
            }
            while (!stack.Empty())
            {
                reversePolishNotation.Add(stack.Pop());
            }
            return reversePolishNotation;
        }

        public static double Parse(string expression)
        {
            var preparedStr = PrepareString(expression);
            var getedToken = GetTokens(preparedStr);
            var reversedPolishNotation = ConvertToReversePolishNotation(getedToken);
            Stack stack = new Stack();
            foreach (var t in reversedPolishNotation)
            {
                switch (t.Type)
                {
                    case TokenType.Number:
                        stack.Push(t);
                        break;
                    case TokenType.Operator:
                    {
                        var operand1 = ConvertlexemeToDouble(stack.Pop().Lexeme);
                        var operand2 = ConvertlexemeToDouble(stack.Pop().Lexeme);
                        var smallResult = MathDictionary.Operators[t.Lexeme](operand1, operand2);
                        stack.Push(new Token(smallResult.ToString(CultureInfo.InvariantCulture),TokenType.Number)); 
                    }
                        break;
                    case TokenType.Function:
                    {
                        var operand = ConvertlexemeToDouble(stack.Pop().Lexeme);
                        var smallResult = MathDictionary.Functions[t.Lexeme](operand);
                        stack.Push(new Token(smallResult.ToString(CultureInfo.InvariantCulture),TokenType.Number));
                    }
                        break;
                    case TokenType.Constant:
                        var constant = MathDictionary.Constants[t.Lexeme];
                        stack.Push(new Token(constant.ToString(CultureInfo.InvariantCulture),TokenType.Constant));
                        break;
                    default:
                        throw  new ArgumentException("Bad exeption string");
                }
            }
            var result = double.Parse(stack.Pop().Lexeme, CultureInfo.InvariantCulture);
            return result;
        }
        private static double ConvertlexemeToDouble(string lexeme)
        {
            return double.Parse(lexeme.Replace(',', '.'),CultureInfo.InvariantCulture); 
        }
    }
 }







