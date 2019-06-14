using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAliReza.BackEnd
{
    public class Shoppingcart
    {
        private string ProductNamE;

        public string ProductName
        {
            get { return ProductNamE; }
            set { ProductNamE = value; }
        }

        private int PricE;

        public int Price
        {
            get { return PricE; }
            set { PricE = value; }
        }

        private string PersonUseR;

        public string PersonUser
        {
            get { return PersonUseR; }
            set { PersonUseR = value; }
        }

        private string PersonPasS;

        public string PersonPass
        {
            get { return PersonPasS; }
            set { PersonPasS = value; }
        }

    }
}
