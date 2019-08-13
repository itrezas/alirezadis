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
    /// Interaction logic for Checkuser.xaml
    /// </summary>
    public partial class Checkuser : UserControl
    {
        Returning_Info returning_info = new Returning_Info();
        public Checkuser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person person2 = returning_info.Return_Info_DB(username.Text, password.Text);

            List<string> vs = new List<string>();
            vs.Add(person2.FirstName);
            vs.Add(person2.LastName);
            vs.Add(person2.Telephon);
            vs.Add(person2.E_Mail);

            InfO.ItemsSource = vs;
        }
    }
}
