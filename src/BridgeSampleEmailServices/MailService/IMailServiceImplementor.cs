namespace BridgeSampleEmailServices.MailService
{
    public interface IMailServiceImplementor
    {
        void SendEmail(string  Reciver,string Title,string Text);
    }
    public class GmailService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Text)
        {
            Console.WriteLine($"Email --{Text}--Send to {Reciver}--with **{nameof(GmailService)}***");
        }
    }
    public class YahooService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Text)
        {
            Console.WriteLine($"Email --{Text}--Send to {Reciver}--with **{nameof(YahooService)}***");

        }
    }
    public class MyComponyMailService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Text)
        {
            Console.WriteLine($"Email --{Text}--Send to {Reciver}--with **{nameof(MyComponyMailService)}***");
        }
    }
}
