using BridgeSampleEmailServices.MailService;

namespace BridgeSampleEmailServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailServiceAbstraction mailService=new RefindeMailService();
            mailService.Send(new EmailInfoDto("MOHAMADREZAKIANI9@YAHOO.COM","TEST Mail Service","this is a test for service mail  "));
            Console.ReadKey();
        }
    }
}
