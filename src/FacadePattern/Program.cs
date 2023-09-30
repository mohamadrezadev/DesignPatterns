namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Facade facade = new Facade();
            facade.dosomething();
            Console.ReadLine();
        }
    }

}
