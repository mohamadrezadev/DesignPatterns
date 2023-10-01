Console.WriteLine("Hello, World!");
Client.RunTemplateMethode(new ConcreateClass1());
Console.WriteLine("---------------------------------------------------------");
Client.RunTemplateMethode(new ConcretClass2());
public class Client
{
    public static void RunTemplateMethode(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}