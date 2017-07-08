using System;
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
using TestWork.Pages;


namespace TestWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenMainPage();
        }

        private void OpenMainPage()
        {
            Frame.NavigationService.Navigate(new MainPage());
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(new MainPage());
        }
    }
}
