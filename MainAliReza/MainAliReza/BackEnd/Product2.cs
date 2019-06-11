using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class Product2
    {

        public DBController dbController = new DBController();

        public ConnectingDB dB = new ConnectingDB();

        public void Add_Product(List<string>jj,string UserAdmin,string PassAdmin)
        {
            if(dbController.Checklogin_Admin(UserAdmin,PassAdmin))
            {
                Product product = new Product() { Name = jj[0], Category =jj[1], Price = jj[2], Weight = jj[3], Brand = jj[4], Mojody_Anbar = jj[5], General_Explanation = jj[6], Picture = jj[7] };

                using (dB)
                {
                    dB.product1.Add(product);
                    dB.SaveChanges();
                }
            }
        }

        public void Edit_Product(List<string> ii, string UserAdmin, string PassAdmin,string Id)
        {

        }

    }
}
