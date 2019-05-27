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

namespace MainAliReza.FrontEnd
{
    /// <summary>
    /// Interaction logic for Customer_Dashboard.xaml
    /// </summary>
    public partial class Customer_Dashboard : UserControl
    {
        static string username;
        static string password;


        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            /////    استفاده کنم؟؟؟؟؟؟؟؟PUK چطوری از تابع  
            string[] puk;
            puk = PUK();//؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟؟


        }
    }
}
