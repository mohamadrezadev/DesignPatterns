// See https://aka.ms/new-console-template for more information

public class CheckUserAcitveUser : TakeATaxiHandler
{
    public override ResponseContext Excute( RequestContext request )
    {
        if (request.UserId != 1)
        {
            Console.WriteLine("User Not Active");
            return new ResponseContext
            {
                isSuccess = true,
                Message = "User not active "
            };
        }
        else if (Successor is not null)
        {
            Console.WriteLine("User is Active");
            return Successor.Excute(request);
        }
        else
        {
            return new ResponseContext { isSuccess = false, Message = "Error" };
        }
    }
}