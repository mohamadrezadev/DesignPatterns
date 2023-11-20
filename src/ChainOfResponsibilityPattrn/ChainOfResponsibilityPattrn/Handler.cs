// See https://aka.ms/new-console-template for more information
public abstract class Handler
{
    protected Handler successor;
    
    public void Set_successor(Handler handler )
    {
       this.successor = handler;
    }
    public abstract void HandelRequest(int request);

    
}
public class ConcreateHandelr1 : Handler
{
    public override void HandelRequest(int request )
    {
        if (request < 50)
        {
            Console.WriteLine($"{nameof(ConcreateHandelr1.HandelRequest)}1, req:{request}  ");
        }
         else if(successor is not null)
            { 
            successor.HandelRequest(request);
        }

    }
}
public class ConcreateHandelr2: Handler
{
    public override void HandelRequest( int request )
    {
        if(request >= 50)
        {
            Console.WriteLine($"{nameof(ConcreateHandelr2.HandelRequest)}2 , req:{request}  ");

        }
        else if (successor is not null)
        {
              successor.HandelRequest(request);
        }
    }
}
