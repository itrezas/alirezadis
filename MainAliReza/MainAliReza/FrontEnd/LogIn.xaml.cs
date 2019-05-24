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
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                using (var db = new ConnectingDB())
                {
                    var SignIn = from SI in db.person1
                                 select SI;
                    foreach (var i in SignIn)
                    {
                        if (i.UserName == username.Text)
                        {
                            if (i.PassWord == password.Password)
                                MessageBox.Show("Log IN");
                        }


                    }
                }

            }
            catch(ValueUnavailableException)
            {
                MessageBox.Show("NO");
            }



        }
    }
}
