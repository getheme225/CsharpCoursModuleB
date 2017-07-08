using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using TestWork.Helper;
using TestWork.Pages;


namespace TestWork.ViewModel
{
    public class MainPageViewModel: MainViewModel
    { 
        
        /// <summary>
        /// Обработчик кнопки Задания 1
        /// </summary>
        public RelayCommand<IPageOpenable> GotoWork1 => new RelayCommand<IPageOpenable>((a)=> a.OpenPage(new CarWork()));

        /// <summary>
        /// Обработчки кнопки задания 2
        /// </summary>
        public RelayCommand <IPageOpenable> GotoWork2 => new RelayCommand<IPageOpenable>((a)=> a.OpenPage(new PayBook()));

        public MainPageViewModel()
        {
            
        }

    }
}
