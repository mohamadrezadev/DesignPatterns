using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmapleFactoryMethod.Sms.Kavenegar
{
    public class KavenegarSmsManager:ISmsManager
    {
        public void Send(SmsDto smsDto)
        {
            Console.WriteLine($"Send sms with {nameof(KavenegarSmsManager)} ......");
        }

        public IList<SmsDto> GetSmsList()
        {
            List<SmsDto>  smsList = new List<SmsDto>();
            return smsList;
        }
    }
}
