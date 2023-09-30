namespace Decoratoruml
{
    public class SendEmail
    {
        public void Send()
        {
            Console.WriteLine("Email Sended ......");
        }
    }
    public class SendEmailDecorator : SendEmail
    {
        private readonly SendEmail _sendEmail;

        public SendEmailDecorator(SendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }
        public void Send()
        {
            _sendEmail.Send();
            saveLog();
        }
        private void saveLog()
        {
            Console.WriteLine("saveLog ......!");
        }
    }
}
  