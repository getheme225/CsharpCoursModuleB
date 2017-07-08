using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        /// <summary>
        /// Экземпляр машиный с которым работаем, 
        /// </summary>
        protected Car Car { get; set; }

        /// <summary>
        /// Надо доработать дерева
        /// </summary>
        #region Работа с деревом
        public ObservableCollection<Detail> CarDetails => Car?.Details != null ? new ObservableCollection<Detail>(Car.Details) : null;

        public ObservableCollection<Wheel> WheelsCollection
            =>
                Car?.Details != null
                    ? new ObservableCollection<Wheel>(Car?.Details.Where(d => d is Wheel).Cast<Wheel>())
                    : null;

        public ObservableCollection<Door> DoorsCollection
            =>
            Car?.Details != null
                    ? new ObservableCollection<Door>(Car?.Details.Where(d => d is Door).Cast<Door>())
                    : null;


        #endregion

        /// <summary>
        /// Обработчить переход на странице создания нового экземпляр машины
        /// </summary>
        public RelayCommand <IPageOpenable> CreateNewCarCommand => new RelayCommand<IPageOpenable>(navServic => navServic.OpenPage(new CreateCar()));

        public CarWorkViewModel()
        {
            
        }

        
    }
}
