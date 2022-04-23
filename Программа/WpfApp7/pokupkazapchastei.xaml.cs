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
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для pokupkazapchastei.xaml
    /// </summary>
    public partial class pokupkazapchastei : Window
    {
        public pokupkazapchastei()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show("Спасибо за покупку охлаждение для ноутбука");
            pokypatelokno pt = new pokypatelokno();
            pt.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();
            MessageBox.Show("Спасибо за покупку видеокарты для ПК");
            pokypatelokno pt = new pokypatelokno();
            pt.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            this.Close();
            MessageBox.Show("Спасибо за покупку корпуса для смартфона");
            pokypatelokno pt = new pokypatelokno();
            pt.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            pokypatelokno pt = new pokypatelokno();
            pt.Show();
        }
    }
}
