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
using WpfApp19;

namespace WpfApp19
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    class N
    {
        public void Resh(int a)
        {
            if (a % 10 == 7)
            {
                MessageBox.Show("Число оканчивается на 7");
            }
            else
            {
                MessageBox.Show("Число не оканчивается на 7");
            }
        }
    }
    public partial class Page1 : Page
    {
        int X;
        N n = new N();
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            X = int.Parse(AA.Text);
            n.Resh(X);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2(X));
        }
    }
}
