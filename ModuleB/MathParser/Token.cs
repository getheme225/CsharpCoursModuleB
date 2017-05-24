using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParser
{/// <summary>
/// CharToken, это либо число, либо оператор
/// </summary>
    public class Token
    {
        public string Lexeme { get;}
        public int Priority { get; private set; }
        public TokenType Type { get;}

        public Token()
        {
            Lexeme = "";
        }
        public Token(string lexeme, TokenType type)
        {
            Lexeme = lexeme;
            Type = type;
            switch (lexeme)
            {
                case "^":
                    this.Priority = 3;break;
                case "*":
                    Priority = 2;break;
                case "/":
                    Priority = 2;break;
                case "+":
                    Priority = 1;break;
                case "-":
                    Priority = 1;break;
                default:
                    Priority = 0;break;
            }
        }

        public override string ToString()
        {
            string result = String.Format($"Lexeme: {Lexeme}, Token type: {Type}");
            return result;
        }
    }
}
