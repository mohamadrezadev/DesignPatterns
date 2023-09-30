// See https://aka.ms/new-console-template for more information

using SampleAdapterNotification;

Console.WriteLine("Hello, World!");
ISendMessage Telegram = new Telegram();
Telegram.Send("MyMessage");
ISendMessage watsapp = new Watsapp();
watsapp.Send("MyMessage");


ISendMessage Gmail=new GmailAdapter();
Gmail.Send("new message");

Console.ReadKey();