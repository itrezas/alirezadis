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
                { FirstName = pp[0], LastName = pp[1], Birthday_Day = pp[2], Birthday_Month = pp[3], Birthday_Year = pp[4], E_Mail = pp[5], Gender = pp[9], Mobil = pp[6], PassWord = pp[11], UserName = pp[10], Picture = pp[12], Telephon = pp[7], Sath_E_Dastresy = pp[8] };

                db01.person1.Add(per);
                db01.SaveChanges();
            }
        }
        public void Edit_Person(List<string> qq,string Old_Username,string Old_Password)
        {
            using (ConnectingDB connecting = new ConnectingDB())
            {
                var ss = connecting.person1.Where(k => k.UserName == Old_Username && k.PassWord == Old_Password).FirstOrDefault();
                ss.FirstName = qq[0];
                ss.LastName = qq[1];
                ss.Birthday_Day = qq[2];
                ss.Birthday_Month = qq[3];
                ss.Birthday_Year = qq[4];
                ss.E_Mail = qq[5];
                ss.Mobil = qq[6];
                ss.Telephon = qq[7];
                ss.Gender = qq[8];
                ss.Picture = qq[9];
                ss.UserName = qq[10];
                ss.PassWord = qq[11];
                ss.Sath_E_Dastresy = qq[12];

                connecting.person1.Attach(ss);
                connecting.Entry(ss);
                connecting.SaveChanges();

            }
          
        }
        public void Delete_Person(string us,string ps)
        {
            using (var db02 = new ConnectingDB())
            {
                var tt = db02.person1.Where(a => a.UserName == us && a.PassWord == ps).FirstOrDefault();

            }
        }
        
    }
}
