using System.ComponentModel;
using CompositePatern.SampleCumputer;
namespace CompositePatern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComponnt Hadrdisk = new CompositePatern.SampleCumputer.Leaf("HardDisk",100);
            IComponnt Ram = new CompositePatern.SampleCumputer.Leaf("Ram",200);
            IComponnt Cpu = new CompositePatern.SampleCumputer.Leaf("Cpu",300);
            IComponnt mouse = new CompositePatern.SampleCumputer.Leaf("mouse",50);
            IComponnt keybord = new CompositePatern.SampleCumputer.Leaf("keybord",50);
            IComponnt monitor = new CompositePatern.SampleCumputer.Leaf("monitor",250);

            var Motherbord = new CompositePatern.SampleCumputer.Composite("Motherbord",1000);
            var Case = new CompositePatern.SampleCumputer.Composite("Case",5000);
            var Peripherals = new CompositePatern.SampleCumputer.Composite("Peripherals", 0);
            var computer = new CompositePatern.SampleCumputer.Composite("computer", 0);

            Motherbord.Add(Cpu);
            Motherbord.Add(Ram);

            Peripherals.Add(mouse);
            Peripherals.Add(keybord);

            Case.Add(Motherbord);
            computer.Add(Hadrdisk);

            computer.Add(Case);
            computer.Add(Peripherals);
            computer.Add(monitor);

            computer.DesplayPrice();

            //Component component = new Composite("Root Item",new Component[]
            //{
            //   new Leaf("Leaf 1"),
            //   new Composite("Composite 1"),
            //   new Composite("Composite 2",new Component[]
            //   {
            //       new Leaf("Leaf 2-1"),
            //       new Composite("Composite 2-1",new Component[]
            //       {
            //           new Leaf("Composite 2-1 Leaf 2"),
            //           new Composite("emptu Coposite ",new Component[]{}),
            //       }),
            //   }),
            //});
            //component.Display(1);
            Console.ReadKey();
        }
    }
}
