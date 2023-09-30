
Console.WriteLine("Hello, World!");
ITarget target = new Adapter();
target.Operation();

ITargerClassAdapter classAdapter = new AdapterCalssAdapter();
classAdapter.Operation();
Console.ReadKey();


public interface ITargerClassAdapter
{
    public void Operation();
}

public class AdapteeClassAdapter
{
    public void SpecificOperation()
    {
        Console.WriteLine($"AdapteeClassAdapter.{nameof(SpecificOperation)}");
    }
}
public class AdapterCalssAdapter:AdapteeClassAdapter,ITargerClassAdapter
{

    public void Operation()
    {
        SpecificOperation();
    }
}