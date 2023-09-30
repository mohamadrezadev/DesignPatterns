using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSampleEmailServices.MailService
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceImplementor _implementor;
        public MailServiceAbstraction()
        {
            _implementor = Implentation.GetImplementor();
        }
        public virtual void Send(EmailInfoDto emailInfo)
        {
            _implementor.SendEmail(emailInfo.Reciver,emailInfo.Title,emailInfo.Message );
        }
    }
    public  class RefindeMailService : MailServiceAbstraction
    {

    }
    public record EmailInfoDto(string Reciver,string Title,string Message);
   public static class Implentation
    {
        public static IMailServiceImplementor GetImplementor()
        {
            var config = ConfigurationManager.AppSettings;
            if (config["EmailImplementor"] == "Gmail")
            {
                return new GmailService();
            }
            else if (config["EmailImplementor"] == "Yahoo")
            {
                return new YahooService();
            }
            return new MyComponyMailService();
        }
    }
}
 