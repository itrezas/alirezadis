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
    }
}
