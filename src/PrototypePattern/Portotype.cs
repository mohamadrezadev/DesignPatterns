using System.Diagnostics.Contracts;

public interface IPortotype
{
    public IPortotype Clone();
}

public class ConcreatPortotype1:IPortotype
{
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    public ConcreatPortotype1(int property1,string property2)
    {
        this.Property1 = property1;
        this.Property2 = property2; 
    }
    public IPortotype Clone()
    {
        return (IPortotype)this.MemberwiseClone();
    }
}

public class ConcreatPortotype2:IPortotype
{
    public ConcreatPortotype1 myapp1 { get; set; }

    public ConcreatPortotype2(ConcreatPortotype1 app)
    {
        myapp1 = app;
    }
    public IPortotype Clone()
    {
        var result = (ConcreatPortotype2)this.MemberwiseClone();
        result.myapp1 = (ConcreatPortotype1)this.myapp1.Clone();
        return (IPortotype)result;
    }
}