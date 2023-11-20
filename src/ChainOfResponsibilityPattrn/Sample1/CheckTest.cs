



public class CheckTest : TakeATaxiHandler
{
    public override ResponseContext Excute( RequestContext request )
    {
        Console.WriteLine("Check Test is done ");
        if (Successor is not null)
        {
            return Successor.Excute(request);
        }
        return new ResponseContext { isSuccess = false };
    }
}