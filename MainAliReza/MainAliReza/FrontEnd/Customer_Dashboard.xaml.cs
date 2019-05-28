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
        private string USERNAME;

        public string userName
        {
            get { return USERNAME; }
            set { USERNAME = value; }
        }
        private string PASSWORD;

        public string passWord
        {
            get { return PASSWORD; }
            set { PASSWORD = value; }
        }


        public Customer_Dashboard(string us,string pw)
        {
            InitializeComponent();
            userName = us;
            passWord = pw;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Customer_Edit customer_Edit = new Customer_Edit(userName, passWord);
            

        }
    }
}
