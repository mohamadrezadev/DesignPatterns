// See https://aka.ms/new-console-template for more information
public class CreateOrder : TakeATaxiHandler
{
    public override ResponseContext Excute( RequestContext request )
    {
        bool orderCreated = true;
        if (orderCreated)
        {
            Console.WriteLine("Order Crated .....");
            return Successor.Excute( request );
        }
        else
        {
            //
        }
        return new  ResponseContext { isSuccess = true,Message="Error Order Created " };

    }
}
