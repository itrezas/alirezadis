using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class SaveShoppingCartToDB
    {
        private int Id;

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        private string PersonId;

        public string PersonID
        {
            get { return PersonId; }
            set { PersonId = value; }
        }

        private string Personname;

        public string PersonName
        {
            get { return Personname; }
            set { Personname = value; }
        }

        private string Productname;

        public string ProductName
        {
            get { return Productname; }
            set { Productname = value; }
        }


        private string Productprice;

        public string ProductPrice
        {
            get { return Productprice; }
            set { Productprice = value; }
        }

        private string Personuser;

        public string PersonUser
        {
            get { return Personuser; }
            set { Personuser = value; }
        }

        private string Personpass;

        public string PersonPass
        {
            get { return Personpass; }
            set { Personpass = value; }
        }

        private string PayingBywhichBank;

        public string PayingByWhichBank
        {
            get { return PayingBywhichBank; }
            set { PayingBywhichBank = value; }
        }





    }
}
