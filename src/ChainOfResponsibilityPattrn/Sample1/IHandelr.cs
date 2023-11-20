// See https://aka.ms/new-console-template for more information
public interface IHandelr
{
    IHandelr Set_Successor( IHandelr handelr );
    ResponseContext Excute(RequestContext request );


}
