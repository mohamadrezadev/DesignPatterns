public interface ITarget
{
    public void Operation();
}

public class Adaptee
{
    public void SpecificOperation()
    {
        Console.WriteLine("SpecificOperation");
    }
}

public class Adapter : ITarget
{
    private Adaptee _adaptee;

    public Adapter()
    {
        _adaptee = new Adaptee();

    }
    public void Operation()
    {
        _adaptee.SpecificOperation();
    }
}