public abstract class flyweighit
{
    public abstract void Operation(string extrastate);
}
public class ConcreatFlyweight : flyweighit
{
    private string internalstate;
    public ConcreatFlyweight(string intranalState)
    {
        this.internalstate = intranalState;
    }
    public override void Operation(string extrastate)
    {
        Console.WriteLine($"ConcreatFlyweighit.operation {internalstate} : {extrastate}");
    }
}
public class FlyweighitFactory
{
    private Dictionary<string, flyweighit> flyweighits =
            new Dictionary<string, flyweighit>();

    public flyweighit GetFlyweighit(string key)
    {
        flyweighit flyweighit = null;
        if (flyweighits.TryGetValue(key, out flyweighit)) { }
        else
        {
            flyweighits.Add(key, new ConcreatFlyweight(key));
        }
        return flyweighits[key];

    }
}

public class UnSharedConcreatflyweighit : flyweighit
{
    private IEnumerable<flyweighit> Flyweighits;
    public UnSharedConcreatflyweighit(IEnumerable<flyweighit> flyweighits)
    {
        this.Flyweighits = flyweighits;
    }
    public override void Operation(string extrastate)
    {
        Console.WriteLine("UnSharedConcreatflyweighit .......");
        foreach (var item in Flyweighits)
        {
            item.Operation(extrastate);
        }
    }
}
