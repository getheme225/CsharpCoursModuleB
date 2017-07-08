using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_Car
{
    public abstract class Detail
    {
        /// <summary>
        /// Вес детали
        /// </summary>
        public abstract double Weight { get; }

        /// <summary>
        /// Имя Детали
        /// </summary>
        public abstract string Name { get; }
    }
}
