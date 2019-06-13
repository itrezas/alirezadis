using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class Returning_Info
    {

        DBController DBCONTroller = new DBController();
        ConnectingDB connectingDB = new ConnectingDB();

        //PERSON:

        //returning info of special(one) person for everyone who has the user&pass of the special person:
        public Person Return_Info_DB(string u, string p)
        {
            Person res1 = new Person();

            using (connectingDB)
            {
                res1 = connectingDB.person1.Where(j => j.UserName == u && j.PassWord == p).FirstOrDefault();
            }

            return res1;
        }

        //returning info of all persons just for admin:
        public List<Person> Return_AllInfo_DB_Of_Person(string UserAdmin, string PassAdmin)
        {
            try
            {
                if (DBCONTroller.Checklogin_Admin(UserAdmin, PassAdmin))
                {
                    List<Person> people = new List<Person>();

                    using (connectingDB)
                    {
                        foreach (var i in connectingDB.person1)
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

        //PRODUCT:

        //return all info of products just for admin:
        public List<Product> Return_AllInfo_DB_Of_Product(string UserAdmin, string PassAdmin)
        {
            try
            {
                if (DBCONTroller.Checklogin_Admin(UserAdmin, PassAdmin))
                {

                    List<Product> products = new List<Product>();

                    using (connectingDB)
                    {
                        foreach (var item in connectingDB.product1)
                        {
                            products.Add(item);
                        }
                    }
                    return products;
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //return info of special pruduct for who want it:
        public Product Return_Info(string name)
        {
            Product product = new Product();
            Product pro = new Product();

            try
            {
                using (connectingDB)
                {
                    pro = connectingDB.product1.Where(t => t.Name == name).FirstOrDefault();
                }

                if (Convert.ToInt32(pro.Mojody_Anbar) != 0)
                {
                    product = pro;
                    product.Mojody_Anbar = "Yes";
                    return product;
                }
                else
                    throw new Exception();
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        //return info of special category for who want them:
        public List<Product> Return_Infoes(string category)
        {
            List<Product> products = new List<Product>();
            List<Product> prod = new List<Product>();

            try
            {
                using (connectingDB)
                {
                    foreach (var item in connectingDB.product1)
                    {
                        if (item.Category == category && Convert.ToInt32(item.Mojody_Anbar) != 0)
                        {
                            products.Add(item);
                        }
                    }
                }

                if (products != null)
                {
                    foreach (var i in products)
                    {
                        prod.Add(i);
                    }

                    foreach (var j in prod)
                    {
                        j.Mojody_Anbar = "Yes";
                    }

                    return prod;

                }
                else
                    throw new Exception();

                
            }
            catch (ArgumentNullException)
            {

                throw;
            }
            catch(Exception)
            {

                throw;
            }
        }

        //return general explanation of special pruduct for who want it:
        public ProductGE Return_GeneralExplanation(string name)
        {
            ProductGE productGE = new ProductGE();

            using (connectingDB)
            {
                productGE = connectingDB.productGEs.Where(u => u.Name == name).FirstOrDefault();
            }

                return productGE;
        }

    }
}
