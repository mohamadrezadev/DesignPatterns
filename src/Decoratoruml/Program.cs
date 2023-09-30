using System.Globalization;
using System.Net;

namespace Decoratoruml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent concrete=new ConcreteComponent();
            //concrete.Operation();
            ConcreteDecorator concreteDecorator = new ConcreteDecorator(concrete);
            concreteDecorator.Operation();
            Console.ReadLine();
            SendEmail sendEmail = new SendEmail();
            SendEmailDecorator emailDecorator= new SendEmailDecorator(sendEmail);
            emailDecorator.Send();

            WebClient webClient = new WebClient();
            WebclientDecorator webclientDecorator = new WebclientDecorator(webClient);
            var result= webclientDecorator.DownloadString("https://puya.buqaen.ac.ir/gateway/index.php");
            

            Console.WriteLine("Hello, World!");
        }
        public class WebclientDecorator:WebClient
        {
            private readonly WebClient _webClient;

            public WebclientDecorator(WebClient webClient)
            {
                _webClient = webClient;
            }
            public string DownloadString(string Address)
            {
                if (Address.StartsWith("https://puya.buqaen.ac.ir/gateway/index.php"))
                {
                    return _webClient.DownloadString(Address);
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
    
}
  