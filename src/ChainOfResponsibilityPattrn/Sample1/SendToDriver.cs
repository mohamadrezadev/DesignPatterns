// See https://aka.ms/new-console-template for more information
public class SendToDriver : TakeATaxiHandler
{
    public override ResponseContext Excute( RequestContext request )
    {
        Console.WriteLine("Send To Driver");
        if(Successor is not null)
        {
            return Successor.Excute(request);
        }
        return new ResponseContext
        {
            isSuccess = true,
            Message = "Order Create And Send Driver "
        };
        

    }
}
