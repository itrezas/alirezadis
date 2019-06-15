using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliRezaMain.BackEnd
{
    public class Product2
    {

        public DBController dbController = new DBController();

        public ConnectingDB COnnectingdB = new ConnectingDB();

        public void Add_Product(List<string> jj, string UserAdmin, string PassAdmin)
        {
            if (dbController.Checklogin_Admin(UserAdmin, PassAdmin))
            {
                Product product = new Product() { Name = jj[0], Category = jj[1], Price = jj[2], Weight = jj[3], Brand = jj[4], Mojody_Anbar = jj[5], Picture = jj[6] };

                using (COnnectingdB)
                {
                    COnnectingdB.product1.Add(product);
                    COnnectingdB.SaveChanges();
                }
            }
        }

        public void Edit_Product(List<string> ii, string UserAdmin, string PassAdmin, int Id)
        {
            if (dbController.Checklogin_Admin(UserAdmin, PassAdmin))
            {
                using (COnnectingdB)
                {
                    var pr = COnnectingdB.product1.Where(itEm => itEm.ID == Id).FirstOrDefault();

                    pr.Name = ii[0];
                    pr.Category = ii[1];
                    pr.Price = ii[2];
                    pr.Weight = ii[3];
                    pr.Brand = ii[4];
                    pr.Mojody_Anbar = ii[5];
                    pr.Picture = ii[6];

                    COnnectingdB.product1.Attach(pr);
                    COnnectingdB.Entry(pr);
                    COnnectingdB.SaveChanges();

                }
            }
        }

        public void Delete_Product(string UserAdmin, string PassAdmin, int Id)
        {
            if (dbController.Checklogin_Admin(UserAdmin, PassAdmin))
            {
                using (COnnectingdB)
                {
                    var pt = COnnectingdB.product1.Where(iTem => iTem.ID == Id).FirstOrDefault();

                    COnnectingdB.product1.Remove(pt);

                    foreach (var item in COnnectingdB.product1)
                    {
                        if (item.ID > Id)
                        {
                            item.ID -= 1;
                        }
                    }

                    COnnectingdB.SaveChanges();
                }
            }
        }

    }
}
