namespace _1_SingleResponsibility.Correct_Use
{

    public class MailAdressValidator
    {
        public bool IsMailAdressValid(string input)
        {
            // Kural denetimini yap
            return true;
        }
    }
    public class SendMail
    {
        private MailAdressValidator _validator = new MailAdressValidator();

        public bool SendMailForX(string input, string mailAdress)
        {
            // Kural denetimini _validator nesnesine yaptır
            if (!_validator.IsMailAdressValid(mailAdress))
                return false;

            // Formatlama işlemini yap
            return true;
        }
    }


}
