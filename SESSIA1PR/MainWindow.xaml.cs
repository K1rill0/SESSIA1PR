using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace SESSIA1PR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.string;


            Random r = new Random();
            int a = 5;//количество знаков до запятой
            double d = r.Next(10 ^ a) + r.NextDouble();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((Login.Text == "") || (Password.Text == "") || (Kod.Text == "")) 
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                MessageBox.Show("Поздравляем, вы вошли!");
            }
        }
    }
}
