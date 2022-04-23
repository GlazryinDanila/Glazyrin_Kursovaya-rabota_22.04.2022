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
using System.Windows.Threading;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для glavnoeokno.xaml
    /// </summary>
    public partial class glavnoeokno : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        private int intrerv;
        
        private int minutes = 10;
        
        public glavnoeokno()
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            minutes = 10;
            intrerv--;

            Labelvrema.Content = minutes.ToString() + ":" + intrerv.ToString();
            if (intrerv == 0 && minutes != 0)
            {
                minutes--;
                intrerv = 60;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow Mw = new MainWindow();
            Mw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window1 win1 = new Window1();
            win1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window2 win2 = new Window2();
            win2.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window3 win3 = new Window3();
            win3.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
            pokupkazapchastei pz = new pokupkazapchastei();
            pz.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
            porisovat pr = new porisovat();
            pr.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();
            porisovat pr = new porisovat();
            pr.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            this.Close();
            kod kd = new kod();
            kd.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Close();
            zaphasti zp = new zaphasti();
            zp.Show();
        }
    }
}
