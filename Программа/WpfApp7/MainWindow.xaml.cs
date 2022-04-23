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
using System.Windows.Threading;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;

            CaptchaGenerator();
        }

        int intrerv = 10;
      //  internal int inter;

        void timer_Tick(object sender, EventArgs e)
        {
            intrerv--;
            if (intrerv == 0)
            {
                blockLabel.Visibility = Visibility.Hidden;
                authorizationBorder.Visibility = Visibility.Visible;
                authorizationLabel.Visibility = Visibility.Visible;
                loginTextBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Visible;
                showPassword.Visibility = Visibility.Visible;
                //passwordTextBox.Visibility = Visibility.Visible;
                captchaGenTextBox.Visibility = Visibility.Visible;
                captchaTextBox.Visibility = Visibility.Visible;
                refreshButton.Visibility = Visibility.Visible;
                loginButton.Visibility = Visibility.Visible;
                loginLabel.Visibility = Visibility.Visible;
                passwordLabel.Visibility = Visibility.Visible;
                captchaLabel.Visibility = Visibility.Visible;

                timer.Stop();
                intrerv = 10;
            }

            blockLabel.Content = "Блокировка авторизации " + intrerv.ToString() + " секунд";
        }
        void CaptchaGenerator()
        {
            char[] chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789".ToCharArray();
            string randomString = "";
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomString += chars[ran.Next(0, chars.Length)];
            }
            captchaGenTextBox.Text = randomString;
        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = "";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            String[] ar = allowchar.Split(a);
            String pwd = "";
            string temp = "";

            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }

            if (captchaGenTextBox.Text != "")
            {
                captchaGenTextBox.Text = null;
            }

            captchaGenTextBox.Text = pwd;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = "xd";
            string pass = "xd";


            if (loginTextBox.Text == login)
            {
                if (passwordBox.Password == pass)
                {
                    if (captchaTextBox.Text == captchaGenTextBox.Text)
                    {
                        pokypatelokno gwin = new pokypatelokno();
                        gwin.Owner = this;
                        //    gwin.userLabel.Content = loginTextBox.Text;
                        gwin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Каптча неверная");
                    }
                }
                else
                {
                    MessageBox.Show("Пароль неверный");
                    CaptchaGenerator();
                }
            }
            else
            {
                MessageBox.Show("Логин неверный");
                CaptchaGenerator();
            }


            if (captchaGenTextBox.Text != "" && captchaGenTextBox.Text != captchaTextBox.Text)
            {
                MessageBox.Show("Блокировка 10 секунд");
                timer.Start();
                authorizationLabel.Visibility = Visibility.Hidden;
                authorizationBorder.Visibility = Visibility.Hidden;
                blockLabel.Visibility = Visibility.Visible;
                loginTextBox.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Hidden;
                showPassword.Visibility = Visibility.Hidden;
                passwordTextBox.Visibility = Visibility.Hidden;
                captchaGenTextBox.Visibility = Visibility.Hidden;
                captchaTextBox.Visibility = Visibility.Hidden;
                refreshButton.Visibility = Visibility.Hidden;
                loginButton.Visibility = Visibility.Hidden;
                loginLabel.Visibility = Visibility.Hidden;
                passwordLabel.Visibility = Visibility.Hidden;
                captchaLabel.Visibility = Visibility.Hidden;
            }
            captchaTextBox.Text = null;

        }

        private void showPassword_Click(object sender, RoutedEventArgs e)
        {
            if (showPassword.IsChecked == true)
            {
                passwordTextBox.Text = passwordBox.Password;
                passwordTextBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Hidden;
            }
            else
            {
                passwordBox.Password = passwordTextBox.Text;
                passwordTextBox.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Visible;
            }
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
