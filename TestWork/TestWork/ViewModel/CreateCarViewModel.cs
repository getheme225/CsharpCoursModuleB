using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using TestWork.Helper;
using TestWork.Pages;
using Work1_Car;

namespace TestWork.ViewModel
{ 
    [AddINotifyPropertyChangedInterface]
   public class CreateCarViewModel:CarWorkViewModel 
    {
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

        /// <summary>
        /// Обработчик перехода на странице Информации о машине
        /// </summary>
       public RelayCommand<IPageOpenable> BtsOkRelayCommand => new RelayCommand<IPageOpenable>(openable =>
       {
           Car = new Car(CountWheel, CountDoors, WheelWeight, DoorsWeight, BodyWeight, Name);
           openable.OpenPage(new DetailsPage() {DataContext = new DetailPagesViewModel(Car)});
       } );
          
        public CreateCarViewModel()
        {
                
        }
    }
}
