using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VectorCore
{
    public class Vector<T> : IEnumerable where T : struct
    {
        public T X { get; private set; }
        public T Y { get; private set; }

        public Vector(T x, T y)
        {
            X = x;
            Y = y;
        }

        #region Helper

        /// <summary>
        /// Спомогательный фунции для сложения умножения и деления коодинаты
        /// </summary>
        /// <param name="x">Координат вектора по оси Ох</param>
        /// <param name="y">Координат вектора по оси Оу</param>
        /// <returns></returns>
        private static T Sum(T x, T y)
        {
            return (dynamic) x + (dynamic) y;
        }

        private static T Mul(T x, T y)
        {
            return (dynamic) x * (dynamic) y;
        }

        private static T div(T x, T y)
        {
            return (dynamic) x / (dynamic) y;
        }


        private static T Sub(T x, T y)
        {
            return (dynamic) x - (dynamic) y;
        }

        #endregion

        #region Vectorial Calculs Methods

        public static Vector<T> operator +(Vector<T> v1, Vector<T> v2)
        {
            return new Vector<T>(Sum(v1.X, v2.X), Sum(v1.Y, v2.Y));
        }

        public static Vector<T> operator -(Vector<T> v1, Vector<T> v2)
        {
            return new Vector<T>(Sub(v1.X, v2.X), Sub(v1.Y, v2.Y));
        }

        public static Vector<T> operator *(Vector<T> v, double number)
        {
            return new Vector<T>(number * (dynamic) v.X, number * (dynamic) v.Y);
        }

        public static double operator *(Vector<T> v1, Vector<T> v2)
        {
            return (dynamic) (Sum(Mul(v1.X, v2.X), Mul(v1.Y, v2.Y)));
        }

        /// <summary>
        /// Vectors are Othogonal if their scaliar's product equal to 0
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool AreOthogonal(Vector<T> v1, Vector<T> v2)
        {
            return v1 * v2 == 0;
        }

        /// <summary>
        /// Vectors are Coliniar if their exit some scaliar n, such as, V1 = nV2
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool AreColiniare(Vector<T> v1, Vector<T> v2)
        {
            var detX = div(v1.X, v2.X);
            var detY = div(v1.Y, v2.Y);
            return ((dynamic) detY == (dynamic) detX);
        }

        public double Module()
        {
            return Math.Sqrt(Math.Pow((dynamic) this.X, 2) + Math.Pow((dynamic) this.Y, 2));
        }

        /// <summary>
        /// Are Equal if they has  same moduls 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool Equals(Vector<T> v)
        {
            return Math.Abs(this.Module() - v.Module()) < 0.0001;
        }

        #endregion

        public override string ToString()
        {
            return string.Format($"X= {X} Y= {Y}");
        }


        public IEnumerator<Vector<T>> GetEnumerator()
        {
            return (new List<Vector<T>>()).Cast<Vector<T>>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }  
}
