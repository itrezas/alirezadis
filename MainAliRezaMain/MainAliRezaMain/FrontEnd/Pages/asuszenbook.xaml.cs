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
    /// Interaction logic for asuszenbook.xaml
    /// </summary>
    public partial class asuszenbook : UserControl
    {
        public asuszenbook()
        {
            InitializeComponent();
        }
        public product pr = new product();
        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)Window.GetWindow(this);
            win.body.Children.Remove(this);
            win.body.Children.Add(pr);
        }
    }
}
