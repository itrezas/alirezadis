using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class SaveShoppingCartToDB2
    {
        public void SaveToDB(List<Shoppingcart> shoppingcarts,string user,string pass,string PersonNamE,string PersoNID)
        {
            DBController dBController = new DBController();
            bool CorrectPerson = false;
            foreach (var item in shoppingcarts)
            {
                //1st condition:Is there this person in my DB or no??   2nd condition:Is this shopping cart for this person ???
                if (dBController.Checklogin_Customer(item.PersonUser,item.PersonPass) && item.PersonUser==user && item.PersonPass==pass)
                {
                    CorrectPerson = true;
                    break;
                }
            }

            if (CorrectPerson)
            {

                List<SaveShoppingCartToDB> saveShoppingCartToDBs1 = new List<SaveShoppingCartToDB>();
                SaveShoppingCartToDB saveShoppingCartToDB = new SaveShoppingCartToDB();

                foreach (var item in shoppingcarts)
                {
                    saveShoppingCartToDB.PersonID = PersoNID;
                    saveShoppingCartToDB.PersonName = PersonNamE;
                    saveShoppingCartToDB.ProductName = item.ProductName;
                    saveShoppingCartToDB.ProductPrice = Convert.ToString(item.Price);
                    saveShoppingCartToDB.PersonUser = user;
                    saveShoppingCartToDB.PersonPass = pass;

                    saveShoppingCartToDBs1.Add(saveShoppingCartToDB);
                }

                using (ConnectingDB connectingDB = new ConnectingDB())
                {
                    foreach (var item in saveShoppingCartToDBs1)
                    {
                        connectingDB.saveShoppingCartToDBs.Add(item);
                    }
                    connectingDB.SaveChanges();
                }
                
            }
        }
    }
}
