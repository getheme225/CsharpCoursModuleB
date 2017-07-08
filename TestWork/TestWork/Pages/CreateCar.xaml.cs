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

namespace TestWork.Pages
{
    /// <summary>
    /// Interaction logic for CreateCar.xaml
    /// </summary>
    public partial class CreateCar : Page, IPageOpenable
    {
        public CreateCar()
        {
            InitializeComponent();
        }

        public void OpenPage(Page page)
        {
            this.NavigationService?.Navigate(page);
        }
    }
}
