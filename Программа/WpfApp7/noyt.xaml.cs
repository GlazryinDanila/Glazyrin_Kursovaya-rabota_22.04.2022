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
    /// Логика взаимодействия для noyt.xaml
    /// </summary>
    public partial class noyt : Window
    {
        public noyt()
        {
            InitializeComponent();

           }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            glavnoeokno gl = new glavnoeokno();
            gl.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            this.Close();
            this.Close();
            etozapis ez = new etozapis();
            ez.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window3 win3 = new Window3();
            win3.Show();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
