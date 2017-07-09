using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using PayBookModel;

namespace TestWork.ViewModel
{
    [AddINotifyPropertyChangedInterface]
   public class PayBookViewModel:ViewModelBase
    {
        #region Свойств для  Работы с Фильтрами
        /// <summary>
        /// Флаг для фильтра по диапазону дат
        /// </summary>
        public bool IsSearchByDate { get; set; }

        /// <summary>
        /// Начальная дата фильтрации 
        /// </summary>
        public DateTime StartDate { get; set; }
        
        /// <summary>
        /// Конечная дата фильтрации
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Флаг для фильтра по Имени клиента
        /// </summary>
        public bool IsSearchByClientName { get; set; }

        /// <summary>
        /// Имя клиента для пойска
        /// </summary>
        public string ClientName { get; set; }
        #endregion

        #region Обработчики кнопками
        /// <summary>
        /// Обработчик кнопки "Найти"
        /// </summary>
        public RelayCommand SearchButton { get; set; }

        /// <summary>
        /// Обработчики кнопки "Добавить новый платёж
        /// </summary>
        public RelayCommand AddNewPay { get; set; }
        
        /// <summary>
        /// Обработчик кнопки "Редактировать платеж" надо привязку к SelectedItem  DataGridItem
        /// </summary>
        public RelayCommand EditPay { get; set; }
        #endregion

        #region Список платежи
        
        public ObservableCollection<Payement> Payements { get; set; } 
        public double SumAmount => Payements.Sum(payment => payment.Amount);

        #endregion



        public PayBookViewModel()
        {
            Payements = new ObservableCollection<Payement>(new List<Payement>() { new Payement() { Client = "GETHEME1", PayementDate = DateTime.Today, Amount = 12.0 }, new Payement() { Client = "GETHEME2", PayementDate = DateTime.Today, Amount = 12.0 }, new Payement() { Client = "GETHEME3", PayementDate = DateTime.Today, Amount = 12.0 } });
        }
    }
}
