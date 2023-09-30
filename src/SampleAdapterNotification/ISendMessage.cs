using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmailService;

namespace SampleAdapterNotification
{
    public interface ISendMessage
    {
        public void Send(string message);
    }

    public class Telegram : ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"{nameof(Telegram.Send)} : {message}");
        }
    }
    public class Watsapp:ISendMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"{nameof(Watsapp.Send)} : {message}");
        }
    }

    public class GmailAdapter : ISendMessage
    {
        private GmailService.GmailServiceGoogle _gmailServiceGoogle;

        public GmailAdapter()
        {
            _gmailServiceGoogle=new GmailService.GmailServiceGoogle();
        }
        public void Send(string message)
        {
            _gmailServiceGoogle.SendMail(message);
            
        }
    }
}
