

using SmapleFactoryMethod.FactoryMethod;
using SmapleFactoryMethod.Sms;
using SmapleFactoryMethod.Sms.Kavenegar;

Console.WriteLine("Hello, World!");

ICreator creator=new Creator();
var smsManager= creator.FactoryMethod();
smsManager.Send(new SmsDto() { Message = "test", Reciver = "09104500086", Sender = "09104560086" });