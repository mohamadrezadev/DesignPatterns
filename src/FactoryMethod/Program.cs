
Console.WriteLine("Hello, World!");

var creator = new ConcreteCreator();
ProductService p;
p = creator.FactoryMethod(0);
p.Excute();
p = creator.FactoryMethod(1);
p.Excute();
p = creator.FactoryMethod(3);
p.Excute();

public abstract class ProductService
{
    public abstract void Excute();
}

public class ConcreateProductService1 : ProductService
{
    public override void Excute()
    {
        Console.WriteLine(nameof(ConcreateProductService1.Excute));
    }
}
public class ConcreateProductService2 : ProductService
{
    public override void Excute()
    {
        Console.WriteLine(nameof(ConcreateProductService2.Excute));
    }
}
public class DefultProductService: ProductService
{
    public override void Excute()
    {
        Console.WriteLine(nameof(DefultProductService.Excute));
    }
}

public abstract class Creator
{
    public abstract ProductService FactoryMethod(int i);
}

public class ConcreteCreator : Creator
{
    public override ProductService FactoryMethod(int i)
    {
        if (i>0)
        {
            return new ConcreateProductService1();
        }

        if (i>1)
        {
            return new ConcreateProductService2();
        }

        return new DefultProductService();

    }
}