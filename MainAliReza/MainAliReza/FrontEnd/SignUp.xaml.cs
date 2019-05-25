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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : UserControl
    {
        public string[] sed { get; set; }
        public SignUp()
        {
            InitializeComponent();

            sed = new string[] { "خریدار", "مدیر" };
        }
        public void signupchecker()
        {
            List<string> SU = new List<string>();
            SU.Add(Fn.Text);
            SU.Add(Ln.Text);
            SU.Add(Brtd.Text);
            SU.Add(Brtm.Text);
            SU.Add(Brty.Text);
            SU.Add(Email.Text);
            SU.Add(Mobil.Text);
            SU.Add(Telephone.Text);
            SU.Add(Gender.Text);
            SU.Add(Picture.Text);
            SU.Add(Username.Text);
            SU.Add(PassWord.Password);
            if (SED.Text == "خریدار")
                SU.Add("1");
            if (SED.Text == "مدیر")
                SU.Add("0");


            Person2 person2 = new Person2();
            person2.Add_Person(SU);
        }
        public void Btn_Click(object sender, RoutedEventArgs e)
        {
            signupchecker();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
