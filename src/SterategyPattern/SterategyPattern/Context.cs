public class Context
{
    private Sterategy strategy;

    public Context(Sterategy sterategy)
    {
        this.strategy = sterategy;
    }

    public void ContextInterface()
    {
        strategy.AlgorithmInterface();
    }
}