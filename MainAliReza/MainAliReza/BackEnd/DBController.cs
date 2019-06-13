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



    }
}
