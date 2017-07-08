using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using Work1_Car;

namespace TestWork.ViewModel
{
    [AddINotifyPropertyChangedInterface]
   public class DetailPagesViewModel
    {
        /// <summary>
        /// Выходня информация о машине 
        /// </summary>
        public string Result => ResultBuilder().ToString();

        /// <summary>
        /// Экземпляр машины
        /// </summary>
        private Car  Car { get; set; }
        public DetailPagesViewModel(Car car= null)
        {
            Car = car;
        }

        /// <summary>
        /// Создания выходной информации
        /// </summary>
        /// <returns></returns>
        private StringBuilder ResultBuilder()
        {
            var result = new StringBuilder();

            if (Car?.Details == null) return result;
            foreach (var detail in Car?.Details)
            {
                if (detail is Wheel | detail is Body)
                {
                    result.AppendLine((detail as IRotatable).Move());
                }
                else
                {
                    var door = detail as IDoor;
                    if (door != null) result.AppendLine(door.Open());
                }
            }
            return result;
        }
    }
}
