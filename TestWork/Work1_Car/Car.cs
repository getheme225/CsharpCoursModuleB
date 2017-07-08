using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_Car
{
   public class Car :Detail
   {
       /// <summary>
       /// найменования машини
       /// </summary>
       private string _name;
        
       /// <summary>
       /// колекция детали(Колёц, двери, рамка)
       /// </summary>
       public ICollection<Detail> Details { get; private set; }
        
       public override double Weight => Details.Any() ? Details.Sum(weigthDetail => weigthDetail.Weight) : 0;
       public override string Name => _name;

        /// <summary>
        /// Контрусктор машины
        /// </summary>
        /// <param name="countofWheels"></param>
        /// <param name="countofDoors"></param>
        /// <param name="wheelsWeight"></param>
        /// <param name="doorsWeight"></param>
        /// <param name="bodyWeight"></param>
        /// <param name="name"></param>
       public Car(int countofWheels, int countofDoors, double wheelsWeight, double doorsWeight, double bodyWeight,
           string name)
       {
           DetailInitialisation(countofWheels, countofDoors, wheelsWeight, doorsWeight, bodyWeight);
           this._name = name;
       }

       /// <summary>
       /// Инициялизация детатей автомобил
       /// </summary>
       /// <param name="countofWheels">Количество колеса</param>
       /// <param name="countofDoors"> Количество двери</param>
       /// <param name="wheelsWeight">вес одного колеса</param>
       /// <param name="doorsWeight"> все одной двери</param>
       /// <param name="bodyWeight"> все рамки</param>
       private void DetailInitialisation(int countofWheels, int countofDoors, double wheelsWeight, double doorsWeight,
           double bodyWeight)
       {
            Details = new List<Detail>();
         //Добовления указанное количество Двери в списке детали 
           for (var i = 0; i < countofDoors; i++)
           {
               Details.Add(new Door(doorsWeight, i));
           }
            //Добовления указанное количество коллес в списке детали 
            for (var i = 0; i < countofWheels; i++)
            {
                Details.Add(new Wheel(wheelsWeight, i));
            }
            //добавления рамки
            Details?.Add(new Body(bodyWeight));
       }
   }
}
