using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainAliReza.FrontEnd;

namespace MainAliReza.BackEnd
{
    public class Person2
    {
        public void Add_Person(List<string>pp)
        {
            //SignUp signUp = new SignUp();
            using (var db01 = new ConnectingDB())
            {
                Person per = new Person
                { FirstName =pp[0]  , LastName = pp[1], Birthday_Day = pp[2], Birthday_Month = pp[3], Birthday_Year = pp[4], E_Mail = pp[], Gender = pp[], Mobil = pp[], PassWord = pp[], UserName = pp[], Sath_E_Dastresy = "0 or 1", Picture = pp[], Telephon = pp[] };

                db01.person1.Add(per);
                db01.SaveChanges();
            }
        }
        
    }
}
