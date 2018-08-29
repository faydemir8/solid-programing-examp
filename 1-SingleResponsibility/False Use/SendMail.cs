using System;
using System.Collections.Generic;
using System.Text;

namespace _1_SingleResponsibility.False_Use
{
    public class SendMail
    {
        public bool SendMailForX(string input, string mailAdress)
        {
            // Kural denetimi talep et
            if (!IsMailAdressValid(mailAdress))
                return false;

            // Formatlama işlemini yap
            return true;
        }

        private bool IsMailAdressValid(string mailAdress)
        {
            // Kural denetimini yap
            return true;
        }
    }
}
