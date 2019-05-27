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
            using (var db01 = new ConnectingDB())
            {
                Person per = new Person
                { FirstName =pp[0]  , LastName = pp[1], Birthday_Day = pp[2], Birthday_Month = pp[3], Birthday_Year = pp[4], E_Mail = pp[5], Gender = pp[8], Mobil = pp[6], PassWord = pp[11], UserName = pp[10], Picture = pp[9], Telephon = pp[7], Sath_E_Dastresy=pp[12] };

                db01.person1.Add(per);
                db01.SaveChanges();
            }
        }
        public void Edit_Person()
        {

        }
        public void Delete_Person()
        {

        }
        
    }
}
