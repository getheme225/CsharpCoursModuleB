using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParser
{
    public class Stack
    {
        private readonly List<Token> _tokens;

        public Stack()
        {
            _tokens= new List<Token>();
        }

        public void Push(Token t)
        {
            _tokens.Add(t);
        }

        public Token Pop()
        {
            if (Empty())
            {
                throw new IndexOutOfRangeException("Список Пусть");
            }
            var result = _tokens[_tokens.Count - 1];
            _tokens.RemoveAt(_tokens.Count-1);
            return result;
        }

        public Token Top()
        {
            if (Empty())
            {
                throw new IndexOutOfRangeException("Список Пусть");
            }
            return _tokens[_tokens.Count - 1];
        }

        public bool Empty()
        {
            return (_tokens.Count == 0);
        }      
    }
}
