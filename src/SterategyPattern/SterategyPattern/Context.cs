public class Context
{
    private Strategy strategy;

    public Context(Strategy sterategy)
    {
        this.strategy = sterategy;
    }

    public void ContextInterface()
    {
        strategy.AlgorithmInterface();
    }
}