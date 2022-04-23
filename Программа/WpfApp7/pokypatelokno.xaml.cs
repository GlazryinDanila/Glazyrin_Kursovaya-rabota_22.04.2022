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
    /// Логика взаимодействия для pokypatelokno.xaml
    /// </summary>
    public partial class pokypatelokno : Window
    {
        public pokypatelokno()
        {
            InitializeComponent();
            
        }
        public enum pages
        {
            page1, page2, page3
        }
        public void OpenPage(pages pages)
        {
            if (pages == pages.page1)
            {
                frametimer231.Navigate(new Page1(this));
            }
            if (pages == pages.page2)
            {
                frametimer231.Navigate(new Page2(this));
            }
            if (pages == pages.page3)
            {
                frametimer231.Navigate(new Page3(this));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            zaphasti zp = new zaphasti();
            zp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            zaphasti zp = new zaphasti();
            zp.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OpenPage(pages.page2);
            //this.Close();
            //zaphasti zp = new zaphasti();
            //zp.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            OpenPage(pages.page1);
            //this.Close();
           // zaphasti zp = new zaphasti();
            //zp.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            OpenPage(pages.page3);
            //this.Close();
            //zaphasti zp = new zaphasti();
            //zp.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            OpenPage(pages.page3);
            //this.Close();
            //zaphasti zp = new zaphasti();
            //zp.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Close();
            zaphasti zp = new zaphasti();
            zp.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.Close();
            zaphasti zp = new zaphasti();
            zp.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            OpenPage(pages.page1);
            //  this.Close();
            //  zaphasti zp = new zaphasti();
            //zp.Show(); 
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window3 win3 = new Window3();
            win3.Show();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            this.Close();
            pokupkazapchastei pk = new pokupkazapchastei();
            pk.Show();
        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window3 win3 = new Window3();
            win3.Show();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window2 win2 = new Window2();
            win2.Show();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cпасибо за покупку");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window3 win3 = new Window3();
            win3.Show();
        }
    }
}
