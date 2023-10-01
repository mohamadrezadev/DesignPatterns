public abstract class AbstractClass
{
    public  void TemplateMethod()
    {
        Console.WriteLine($"================>{nameof(AbstractClass)}{nameof(AbstractClass.TemplateMethod)} Start");
        PrimitiveOperation1();
        PrimitiveOperation2();
        Console.WriteLine($"================>{nameof(AbstractClass)}{nameof(AbstractClass.TemplateMethod)} End");
    }

    protected abstract void PrimitiveOperation1();
    protected abstract void PrimitiveOperation2();
}

public class ConcreatClass : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine($"{nameof(ConcreatClass)}{nameof(ConcreatClass.PrimitiveOperation1)}");
    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine($"{nameof(ConcreatClass)}{nameof(ConcreatClass.PrimitiveOperation2)}");
    }
}

public class client
{
    public static void Run(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}