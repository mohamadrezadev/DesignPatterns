public abstract class Strategy
{
    public abstract void AlgorithmInterface();
}

public class ConcreateSterategyA : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($"{nameof(ConcreateSterategyA)} {nameof(ConcreateSterategyA.AlgorithmInterface)}");
    }
}public class ConcreateSterategyB : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($"{nameof(ConcreateSterategyB)}  {nameof(ConcreateSterategyB.AlgorithmInterface)}");
    }
}public class ConcreateSterategyC : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine($" {nameof(ConcreateSterategyC)} {nameof(ConcreateSterategyC.AlgorithmInterface)}");
    }
}