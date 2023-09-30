using SmapleFactoryMethod.Sms.Kavenegar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmapleFactoryMethod.Sms.Twilio
{
    public class TwilioSmsManager:ISmsManager
    {
        public void Send(SmsDto smsDto)
        {
            Console.WriteLine($"Send sms with {nameof(TwilioSmsManager)} ......");
        }

        public IList<SmsDto> GetSmsList()
        {
            List<SmsDto> smsList = new List<SmsDto>();
            return smsList;
        }
    }
}
