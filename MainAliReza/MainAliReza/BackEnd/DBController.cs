using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class DBController
    {
        ConnectingDB connectingDB = new ConnectingDB();
        List<Shoppingcart> Shoppingcarts = new List<Shoppingcart>();

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

        //after login , front_end should call under method:
        public IN KeepIN(string user,string pass)
        {
            IN iN = new IN();

            Person person = new Person();
            using (connectingDB)
            {
                person = connectingDB.person1.Where(o => o.UserName == user && o.PassWord == pass).FirstOrDefault();
            }

            iN.ID = Convert.ToString(person.ID);
            iN.PersonName = person.FirstName + " " + person.LastName;

                return iN;
        }

        //add to shopping cart:
        public void AddToShoppingCart(string ProductNamE,int ProductPricE,string UserName,string PassWord)
        {
            Shoppingcart shoppingcart = new Shoppingcart() { Price = ProductPricE, ProductName = ProductNamE, PersonUser = UserName, PersonPass = PassWord };
            Shoppingcarts.Add(shoppingcart);
        }

        //view shopping cart or buying from shopping cart:
        public List<Shoppingcart> ReturnShoppingCart(string Username, string Password)
        {

            bool CorrectPerson = false;
            try
            {
                foreach (var item in Shoppingcarts)
                {
                    if (item.PersonUser == Username && item.PersonPass == Password)
                    {
                        CorrectPerson = true;
                        break;
                        
                    }

                }
                if (CorrectPerson)
                {
                    return Shoppingcarts;
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
