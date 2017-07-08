﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestWork.Helper;
using TestWork.ViewModel;

namespace TestWork.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page, IPageOpenable
    {
        public MainPage()
        {
            InitializeComponent();
         
        }

        public void OpenPage(Page page)
        {
            var navigationService = this.NavigationService;
            navigationService?.Navigate(page);
        }
    }
}
