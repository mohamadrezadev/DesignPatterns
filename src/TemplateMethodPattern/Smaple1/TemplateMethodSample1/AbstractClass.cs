using Microsoft.Win32;

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        this.Hook1();
        this.BaseOperation1();
        this.RequiredOperation1();
        this.Hook2();
        this.BaseOperation2();
        this.RequiredOperation2();

    }

    protected void BaseOperation1()
    {
        Console.WriteLine($"{nameof(AbstractClass)}{nameof(AbstractClass.BaseOperation1)}.... Run");
    }
    protected void BaseOperation2()
    {
        Console.WriteLine($"{nameof(AbstractClass)}{nameof(AbstractClass.BaseOperation2)}.... Run");
    }

    protected abstract void RequiredOperation1();
    protected abstract void RequiredOperation2();

    protected virtual void Hook1(){}
    protected virtual void Hook2(){}
}