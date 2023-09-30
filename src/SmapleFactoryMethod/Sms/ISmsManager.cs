using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmapleFactoryMethod.Sms;
public interface ISmsManager
{
    void Send(SmsDto smsDto);
    IList<SmsDto> GetSmsList();
}
