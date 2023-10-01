public class ConcretClass2 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine($"--->{nameof(ConcretClass2)}.{nameof(ConcretClass2.RequiredOperation1)}() ...Run");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine($"--->{nameof(ConcretClass2)}.{nameof(ConcretClass2.RequiredOperation2)}() ...Run");
    }
}