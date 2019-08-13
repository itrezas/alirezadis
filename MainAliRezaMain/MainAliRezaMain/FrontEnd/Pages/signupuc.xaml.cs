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
    /// Interaction logic for signupuc.xaml
    /// </summary>
    public partial class signupuc : UserControl
    {
        DBController dBController = new DBController();
        Person2 person2 = new Person2();
        public signupuc()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        public product pr1 = new product();
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> vs = new List<string>();
            vs.Add(firstnametxtb.Text);
            vs.Add(lastnametxtb.Text);
            vs.Add("0");
            vs.Add("0");
            vs.Add("0");
            vs.Add(emailtxtb.Text);
            vs.Add(phonetxtb.Text);
            vs.Add("0");
            vs.Add("0");
            vs.Add(usernametxtb.Text);
            vs.Add(passwordtxtb.Password);
            vs.Add("0");
            person2.Add_Person_FirstAdmin_And_Customers(vs);
            
        MainWindow win3 = (MainWindow)Window.GetWindow(this);
            win3.body.Children.Remove(this);
            win3.body.Children.Add(pr1);


        }
    }
}
