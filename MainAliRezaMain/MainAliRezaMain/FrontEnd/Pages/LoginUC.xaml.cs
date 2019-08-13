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
using MainAliRezaMain.FrontEnd.Pages;
using MainAliRezaMain.BackEnd;

namespace MainAliRezaMain.FrontEnd.Pages
{
    /// <summary>
    /// Interaction logic for LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        DBController dBController = new DBController();
        public LoginUC()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
             signupuc signupobj = new signupuc();

            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(signupobj);
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            product product = new product();
            admin admin1 = new admin();
            if (dBController.Checklogin_Customer(Usernametxtbx.Text,passwordbox.Password))
            {
                MainWindow win = (MainWindow)Window.GetWindow(this);
                win.body.Children.Remove(this);
                win.body.Children.Add(product);
            }
            if(dBController.Checklogin_Admin(Usernametxtbx.Text, passwordbox.Password))
            {
                MainWindow win = (MainWindow)Window.GetWindow(this);
                win.body.Children.Remove(this);
                win.body.Children.Add(admin1);
            }
        }
    }
}
