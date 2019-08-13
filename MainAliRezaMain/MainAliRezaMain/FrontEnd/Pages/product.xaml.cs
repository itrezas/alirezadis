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

namespace MainAliRezaMain.FrontEnd.Pages
{
    /// <summary>
    /// Interaction logic for product.xaml
    /// </summary>
    public partial class product : UserControl
    {
        public product()
        {
            InitializeComponent();
        }

        private void signoutbtn_Click(object sender, RoutedEventArgs e)
        {
            LoginUC login2 = new LoginUC();
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(login2);
        }

        private void profilebtn_Click(object sender, RoutedEventArgs e)
        {
           user   profile1 = new user();
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(profile1);
        }

        private void asuszenbook_Click(object sender, RoutedEventArgs e)
        {
            asuszenbook product1 = new asuszenbook();
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(product1);
        }

        private void asuszenbookux_Click(object sender, RoutedEventArgs e)
        {
            ASUSSZENBOOKUX product2 = new ASUSSZENBOOKUX();
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(product2);
        }

        private void ASUSSN580_Click(object sender, RoutedEventArgs e)
        {
            ASUSSN580 product3= new ASUSSN580();
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(product3);
        }

        private void asusviewbook_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
