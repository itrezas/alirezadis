using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class Person2
    {
        public void Add_Person(string firstname, string lastname, string birthday_day, string birthday_month, string birthday_year, string e_mail, string gender, string mobil, string password, string username, string sath_e_dastresy, string picture, string telephon)
        {
            using (var db01 = new ConnectingDB())
            {
                Person per = new Person
                { FirstName = firstname, LastName = lastname, Birthday_Day = birthday_day, Birthday_Month = birthday_month, Birthday_Year = birthday_year, E_Mail = e_mail, Gender = gender, Mobil = mobil, PassWord = password, UserName = username, Sath_E_Dastresy = sath_e_dastresy, Picture = picture, Telephon = telephon };

                db01.person1.Add(per);
                db01.SaveChanges();
            }
        }
        public void
    }
}
