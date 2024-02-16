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

namespace WpfApp19
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    class Res
    {
        public void R(int a)
        {
            if (a >= 0)
            {
                a -= 8;
            }
            else
            {
                a += 6;
            }
            MessageBox.Show($"Ответ: {a}");
        }
    }
    public partial class Page2 : Page
    {
        int X;
        int K;
        Res res = new Res();
        public Page2(int x)
        {
            InitializeComponent();
            X = x;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            K = int.Parse(AA.Text);
            res.R(K);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Сумма: {X + K}");
        }
    }
}
