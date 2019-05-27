using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    class DBController
    {
        public bool Checklogin(string user,string pass)
        {
            try
            {
                var db = new ConnectingDB();
                var res = db.person1.Where(i => i.UserName == user && i.PassWord == pass).FirstOrDefault();

                if (res == null)
                    throw new Exception();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Person> Return_Info_DB(string u,string p)
        {
            var db02 = new ConnectingDB();
            var res1 = db02.person1.Where(j => j.UserName == u && j.PassWord == p).FirstOrDefault();
            List<Person> people = new List<Person>();
            people.Add(res1);
            return people;
            
            
        }
    }
}
