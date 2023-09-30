using Bridge.Abstractions;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction    abstraction= new RefinedAbstraction();
            abstraction.Function();
            Console.WriteLine("Hello, World!");
        }
    }
}
