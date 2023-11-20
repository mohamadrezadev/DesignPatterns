// See https://aka.ms/new-console-template for more information
public abstract class TakeATaxiHandler : IHandelr
{
    protected IHandelr Successor;

    public abstract ResponseContext Excute( RequestContext request );
    
    public IHandelr Set_Successor( IHandelr handelr )
    {
        this.Successor = handelr;
        return Successor;
    }
}
