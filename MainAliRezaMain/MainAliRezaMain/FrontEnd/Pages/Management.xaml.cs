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
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : UserControl
    {
        public Management()
        {
            InitializeComponent();
        }
        public product addpro = new product();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win3 = (MainWindow)Window.GetWindow(this);
            win3.body.Children.Remove(this);
            win3.body.Children.Add(addpro);
        }
    }
}
