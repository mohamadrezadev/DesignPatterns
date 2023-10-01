public class ConcreateClass1 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine($"--->{nameof(ConcreateClass1)}.{nameof(ConcreateClass1.RequiredOperation1)}() ...Run");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine($"--->{nameof(ConcreateClass1)}.{nameof(ConcreateClass1.RequiredOperation2)}() ...Run");
    }

    protected override void Hook1()
    {
        Console.WriteLine($"-----> {nameof(ConcreateClass1)}{nameof(ConcreateClass1.Hook1)} ..Run");
        base.Hook1();
    }

    protected override void Hook2()
    {
        Console.WriteLine($"-----> {nameof(ConcreateClass1)}{nameof(ConcreateClass1.Hook2)} ..Run");

        base.Hook2();
    }
}