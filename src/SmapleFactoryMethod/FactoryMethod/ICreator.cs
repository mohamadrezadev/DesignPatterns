using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmapleFactoryMethod.Sms;
using SmapleFactoryMethod.Sms.Kavenegar;
using SmapleFactoryMethod.Sms.Twilio;

namespace SmapleFactoryMethod.FactoryMethod
{
    public interface ICreator
    {
        ISmsManager FactoryMethod();
    }

    public class Creator: ICreator
    {
        public ISmsManager FactoryMethod()
        {
            string Config = "Kavenegar";
            if (Config.Equals("twilio"))
            {
                return new TwilioSmsManager();
            }

            return new KavenegarSmsManager();
        }
    }
}
