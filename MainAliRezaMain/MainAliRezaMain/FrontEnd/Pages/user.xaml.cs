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
using MainAliRezaMain.BackEnd;

namespace MainAliRezaMain.FrontEnd.Pages
{
    /// <summary>
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
        }

        private void backbtn4_Click(object sender, RoutedEventArgs e)
        {
            product produc2 = new product();
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(produc2);
        }

        private void showinfobtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sveinfrmationbtn_Click(object sender, RoutedEventArgs e)
        {
           
            
        }
    }
}
