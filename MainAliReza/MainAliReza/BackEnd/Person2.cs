using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class Person2
    {

        DBController dBController = new DBController();

        public void Add_Person_ByAdmin(List<string> pp)
        {
            using (var db01 = new ConnectingDB())
            {
                Person per = new Person
                { FirstName = pp[0], LastName = pp[1], Birthday_Day = pp[2], Birthday_Month = pp[3], Birthday_Year = pp[4], E_Mail = pp[5], Gender = pp[9], Mobil = pp[6], PassWord = pp[11], UserName = pp[10], Picture = pp[12], Telephon = pp[7], Sath_E_Dastresy = pp[8] };

                db01.person1.Add(per);
                db01.SaveChanges();
            }
        }

        public void Add_Person_FirstAdmin_And_Customers(List<string> pp)
        {
            
            using (var db01 = new ConnectingDB())
            {
                //first person add (as admin):
                Person p = db01.person1.First();
                if(p==null)
                {
                    Person per = new Person
                    { FirstName = pp[0], LastName = pp[1], Birthday_Day = pp[2], Birthday_Month = pp[3], Birthday_Year = pp[4], E_Mail = pp[5], Gender = pp[9], Mobil = pp[6], PassWord = pp[11], UserName = pp[10], Picture = pp[12], Telephon = pp[7], Sath_E_Dastresy = "0" };

                    db01.person1.Add(per);
                    db01.SaveChanges();
                }
                //other person add(as customer)
                else if(p!=null)
                {
                    Person per = new Person
                    { FirstName = pp[0], LastName = pp[1], Birthday_Day = pp[2], Birthday_Month = pp[3], Birthday_Year = pp[4], E_Mail = pp[5], Gender = pp[9], Mobil = pp[6], PassWord = pp[11], UserName = pp[10], Picture = pp[12], Telephon = pp[7], Sath_E_Dastresy = "1" };

                    db01.person1.Add(per);
                    db01.SaveChanges();
                }
                
            }
        }

        //customer edit info of himself(herself):
        public void Edit_Person_ByCustomer(List<string> qq, string Old_Username, string Old_Password)
        {
            try
            {
                if (dBController.Checklogin_Customer(Old_Username, Old_Password))
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
                        ss.Gender = qq[9];
                        ss.Picture = qq[12];
                        ss.UserName = qq[10];
                        ss.PassWord = qq[11];
                        ss.Sath_E_Dastresy = "1";

                        connecting.person1.Attach(ss);
                        connecting.Entry(ss);
                        connecting.SaveChanges();

                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {

                throw;
            }
            

            

        }

        //admin edit info of himself(herself):
        public void Edit_Person_ByAdmin(List<string> qq, string Old_Username, string Old_Password)
        {
            try
            {
                if (dBController.Checklogin_Admin(Old_Username, Old_Password))
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
                        ss.Gender = qq[9];
                        ss.Picture = qq[12];
                        ss.UserName = qq[10];
                        ss.PassWord = qq[11];
                        ss.Sath_E_Dastresy = qq[8];

                        connecting.person1.Attach(ss);
                        connecting.Entry(ss);
                        connecting.SaveChanges();

                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {

                throw;
            }
            



        }
        
        //admin edit info of customer:
        public void Edit_Customer_ByAdmin(List<string> qq, string Old_UsernameCustomer, string Old_PasswordCustomer,string UserAdmin,string PassAdmin)
        {
            try
            {
                if (dBController.Checklogin_Admin(UserAdmin, PassAdmin) && dBController.Checklogin_Customer(Old_UsernameCustomer, Old_PasswordCustomer))
                {
                    using (ConnectingDB connecting = new ConnectingDB())
                    {
                        var ss = connecting.person1.Where(k => k.UserName == Old_UsernameCustomer && k.PassWord == Old_PasswordCustomer).FirstOrDefault();
                        ss.FirstName = qq[0];
                        ss.LastName = qq[1];
                        ss.Birthday_Day = qq[2];
                        ss.Birthday_Month = qq[3];
                        ss.Birthday_Year = qq[4];
                        ss.E_Mail = qq[5];
                        ss.Mobil = qq[6];
                        ss.Telephon = qq[7];
                        ss.Gender = qq[9];
                        ss.Picture = qq[12];
                        ss.UserName = qq[10];
                        ss.PassWord = qq[11];
                        ss.Sath_E_Dastresy = qq[8];

                        connecting.person1.Attach(ss);
                        connecting.Entry(ss);
                        connecting.SaveChanges();

                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {

                throw;
            }
            



        }

        public void Delete_Person(string us, string ps)
        {

            if(dBController.Checklogin_Admin(us,ps)||dBController.Checklogin_Customer(us,ps))
            {
                using (var db02 = new ConnectingDB())
                {
                    var tt = db02.person1.Where(a => a.UserName == us && a.PassWord == ps).FirstOrDefault();

                    int id = tt.ID;
                    //remove person:
                    db02.person1.Remove(tt);
                    //ordering ID number in database after deleting a person:
                    foreach (var item in db02.person1)
                    {
                        if (item.ID>id)
                        {
                            item.ID -= 1;
                        }
                    }

                    db02.SaveChanges();

                }
            }



        }

    }
}
