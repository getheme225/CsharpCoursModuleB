using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Work1_Car
{
    public class Door:Detail,IDoor
    {
        /// <summary>
        /// Флаг открыта/закрыта Дверь
        /// </summary>
        private bool _isOpen;

   
        /// <summary>
        /// Вес двери 
        /// </summary>
        [NotNullValidator]
        public  override double Weight { get;  }

        /// <summary>
        /// Имя деталью, по умольчанию Дверь
        /// </summary>
        public  override string Name { get; }

        /// <summary>
        /// Порядковый номер двери 
        /// </summary>
        public int Number { get;}

        /// <summary>
        /// Конструктор двери 
        /// </summary>
        /// <param name="weigth"> Вес Дверю</param>
        /// <param name="number">Поряковый номер двери</param>
        /// <param name="name"> Имя деталью, по умольчанию "Дверь"</param>
        public Door(double weigth, int number , string name = "Дверь" )
        {
            _isOpen = false;
            Weight = weigth;
            Number = number;
            Name = name;
        }

        /// <summary>
        /// Реализация интерфейса IDoor, выходная строка зависит от флага <param name="isOpen" />
        /// </summary>
        /// <returns> «Дверь № <see cref="Number"/>"Number"/> (открыта/закрыта) »</returns>
        public string Open()
        {
            var answer = $"{Name} № {Number + 1} " + (_isOpen ? "Открыта" : "Закрыта");
            _isOpen = !_isOpen;
            return answer;
        }
    }
}
