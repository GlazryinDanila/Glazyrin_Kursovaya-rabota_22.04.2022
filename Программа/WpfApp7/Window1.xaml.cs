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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            zaphasti zp = new zaphasti();
            zp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            noyt nt = new noyt();
            nt.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            zaphasti zp = new zaphasti();
            zp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            pk p = new pk();
            p.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
            pk p = new pk();
            p.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
            pokypatelokno pt = new pokypatelokno();
            pt.Show();
        }
    }
}
