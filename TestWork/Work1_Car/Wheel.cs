using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Work1_Car
{
    public class Wheel : Detail,IRotatable
    {
        /// <summary>
        /// Вес колеса
        /// </summary>
        private double _weight;

        /// <summary>
        /// Вес Колеса, attribute [NotNullValidator] из Microsoft.Practices.EnterpriseLibrary
        /// </summary>
        [NotNullValidator]
        public override double Weight => _weight;

        /// <summary>
        /// Массив Гайки, по умольчанью массив содержит 6 элементов 
        /// </summary>
        public ICollection<Nut> Nuts { get; set; }
        
        /// <summary>
        /// Имя колеса 
        /// </summary>
        public sealed override string Name { get; }

        /// <summary>
        /// Порядковый номер колеса
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Конструктор колеса
        /// </summary>
        /// <param name="weigth"> Вес колесо, дольжен быть больше 0</param>
        /// <param name="number"> Порядковый номер колеса</param>
        /// <param name="name"> Имя детель по умольчанью "колесо"</param>
        public Wheel(double weigth, int number, string name = "Колесо")
        {
            this._weight = weigth;
            Number = number;
            Nuts = Enumerable.Repeat(new Nut(), 6).ToArray();
            Name = name;
        }

        /// <summary>
        /// Реализаация IRotatable 
        /// </summary>
        /// <returns> «Колесо №  <see cref="Number"/> вращается».</returns>
        public string Move()
        {
            return $"{Name} № {Number +1 }  вращается .";
        }
    }

    
}
