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
using MainAliReza.BackEnd;

namespace MainAliReza.FrontEnd
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : UserControl
    {
        //public string[] PUP()
        //{
        //    string[] arr = new string[] { username.Text, password.Password };
        //    return arr;
        //}
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DBController dBController = new DBController();
            if (dBController.Checklogin(username.Text, password.Password)) 
            {
                Customer_Dashboard.PUK(username.Text, password.Password);
                

            }
            else
            {

            }
        }
    }
}
