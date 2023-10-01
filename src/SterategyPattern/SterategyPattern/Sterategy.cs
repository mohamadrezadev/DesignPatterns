public abstract class Sterategy
{
    public abstract void AlgorithmInterface();
}

public class ConcreateSterategyA : Sterategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($"{nameof(ConcreateSterategyA)} {nameof(ConcreateSterategyA.AlgorithmInterface)}");
    }
}public class ConcreateSterategyB : Sterategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($"{nameof(ConcreateSterategyB)}  {nameof(ConcreateSterategyB.AlgorithmInterface)}");
    }
}public class ConcreateSterategyC : Sterategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($" {nameof(ConcreateSterategyC)} {nameof(ConcreateSterategyC.AlgorithmInterface)}");
    }
}