using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class DBController
    {
        public bool Checklogin_Customer(string user,string pass)
        {
            try
            {
                var db = new ConnectingDB();
                var res = db.person1.Where(i => i.UserName == user && i.PassWord == pass).FirstOrDefault();

                if (res != null && res.Sath_E_Dastresy == "1")
                    return true;
                else
                    throw new Exception();

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Checklogin_Admin(string user, string pass)
        {
            try
            {
                var db = new ConnectingDB();
                var res = db.person1.Where(i => i.UserName == user && i.PassWord == pass).FirstOrDefault();

                if (res != null && res.Sath_E_Dastresy == "0")
                    return true;
                else
                    throw new Exception();

            }
            catch (Exception)
            {
                return false;
            }
        }

        public Person Return_Info_DB(string u,string p)
        {
            var db02 = new ConnectingDB();
            var res1 = db02.person1.Where(j => j.UserName == u && j.PassWord == p).FirstOrDefault();
            Person person = new Person();
            person = res1;
            return person;
        }

        public List<Person> Return_AllInfo_DB(string UserAdmin, string PassAdmin)
        {
            try
            {
                if (Checklogin_Admin(UserAdmin, PassAdmin))
                {
                    List<Person> people = new List<Person>();

                    using (ConnectingDB dB = new ConnectingDB())
                    {
                        foreach (var i in dB.person1)
                        {
                            people.Add(i);
                        }
                    }

                    return people;
                }

                else
                    throw new Exception();
            }
            catch (Exception)
            {
                throw;
               
            }
            
        }



    }
}
