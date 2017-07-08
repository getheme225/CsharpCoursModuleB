using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Work1_Car
{
   public class Body: Detail, IRotatable,IDoor
    {
        /// <summary>
        /// Вес Рамки
        /// </summary>
        private double _weight;

        [NotNullValidator]
        public override double Weight => _weight;

        /// <summary>
        /// Имя детали, по умольчанию Рамка
        /// </summary>
        public sealed override string Name { get; }

        /// <summary>
        /// Конструктор класса рамка
        /// </summary>
        /// <param name="weight"> вес рамки</param>
        /// <param name="name"> Имя деталью, по умольчанию Рамка</param>
        public Body(double weight, string name="Рамка")
        {
            this._weight = weight;
            Name = name;
        }

        /// <summary>
        /// Реализация Интерфейс IMove
        /// </summary>
        /// <returns> Машина едет.</returns>
        public string Move()
        {
            return "Машина едет.";
        }

        /// <summary>
        /// Реализация Интерфейс IRotatable
        /// </summary>
        /// <returns></returns>
        public string Open()
        {
            return "Увы, это не дверь.";
        }
    }
}
