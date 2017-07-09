using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using TestWork.Helper;
using TestWork.Pages;
using Work1_Car;

namespace TestWork.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CarWorkViewModel:ViewModelBase
    {
        #region Create Car
        /// <summary>
        /// Экземпляр машиный с которым работаем, 
        /// </summary>
        public Car Car { get; set; }
      
        /// <summary>
        /// Найминования машины
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество Колес
        /// </summary>
        public int CountWheel { get; set; }

        /// <summary>
        /// Вес колеса
        /// </summary>
        public double WheelWeight { get; set; }

        /// <summary>
        /// Количество Дверей  
        /// </summary>
        public int CountDoors { get; set; }

        /// <summary>
        /// Вес двери
        /// </summary>
        public double DoorsWeight { get; set; }

        /// <summary>
        /// Вес рамки
        /// </summary>
        public double BodyWeight { get; set; }
        #endregion

        #region Обработчики кнопок
        /// <summary>
        /// Обработчик создания машины, и дверева вложенности
        /// </summary>
        public RelayCommand BtsOkRelayCommand => new RelayCommand(() => Car = new Car(CountWheel, CountDoors, WheelWeight, DoorsWeight, BodyWeight, Name));

        /// <summary>
        /// Обработчик кнопки Вращения для управление вращением
        /// </summary>
        public RelayCommand BtsMoveCommand => new RelayCommand(() =>
        {
            TectResult = ResultBuilder().ToString();
            IsMove = false;
        });
        
        /// <summary>
        /// Флаг IsEnable кнопки Вращения
        /// </summary>
        public bool IsMove { get; set; }

        /// <summary>
        /// Порядковый номер двери
        /// </summary>
        public uint SelectedDoor { get; set; }

        /// <summary>
        /// Обробтчик кнопки Открыть/Закрыть Дверь "управление дверями"
        /// </summary>
        public RelayCommand OpenCloseDoor => new RelayCommand(() =>
        {
            try
            {
                var selecteddoor = Car.Details.FirstOrDefault(d => ((Door)d).Number == SelectedDoor - 1) as Door;
                TectResult += $" \n {selecteddoor?.Open()}";
            }
            catch (Exception e)
            {
                TectResult += $" \n Дверь № {SelectedDoor} Не существует";
            }
        });

        /// <summary>
        /// Обработчик кнопки расчета веса машины. 
        /// </summary>
        public RelayCommand CalculateWeight => new RelayCommand(() =>
        {
            TectResult += $"\n Общее вес машины : {Car?.Weight} Кг ";
        });
        #endregion

        #region Создания Тестовое поле
        /// <summary>
        /// Выходная информация 
        /// </summary>
        public string TectResult { get; set; }
      
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
                    var door = detail as Door;
                    if (door != null) result.AppendLine(door.Open());
                }
            }
            return result;
        }
        #endregion

        #region Работа с деревом
        /// <summary>
        /// Дерево
        /// </summary>
        public List<TreeNodes> Tree =>  (Car !=null)? new List<TreeNodes> { new TreeNodes() { Item = Car , Name=Car.Name } } : new List<TreeNodes>() ;
        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        public CarWorkViewModel()
        {
            IsMove = true;
        }        
    }
}
