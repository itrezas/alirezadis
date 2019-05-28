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
    /// Interaction logic for Customer_Edit.xaml
    /// </summary>
    public partial class Customer_Edit : UserControl
    {
        private string OLD_USERNAME;

        public string OLD_Username
        {
            get { return OLD_USERNAME; }
            set { OLD_USERNAME = value; }
        }

        private string OLD_PASSWORD;

        public string OLD_Password
        {
            get { return OLD_PASSWORD; }
            set { OLD_PASSWORD = value; }
        }


        public Customer_Edit(string OU,string OP)
        {
            InitializeComponent();
            OLD_Username = OU;
            OLD_Password = OP;
        }

        private void EditSave_Click(object sender, RoutedEventArgs e)
        {
            List<string> vs = new List<string>();
            vs.Add(FN.Text);
            vs.Add(LN.Text);
            vs.Add(BRTD.Text);
            vs.Add(BRTM.Text);
            vs.Add(BRTY.Text);
            vs.Add(E_MAIL.Text);
            vs.Add(MOBIL.Text);
            vs.Add(TELEPHON.Text);
            vs.Add(GENDER.Text);
            vs.Add(PICTURE.Text);
            vs.Add(USERNAME.Text);
            vs.Add(PASSWORD.Password);
            vs.Add(S_E_D.Text);
            Person2 person2 = new Person2();
            person2.Edit_Person(vs, OLD_Username, OLD_Password);
        }
    }
}
