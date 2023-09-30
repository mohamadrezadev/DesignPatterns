using System.Xml.Linq;

namespace CompositePatern
{
    public class Composite : Component
    {
        private List<Component> components = new List<Component>();
        public Composite(string name):base(name)
        { }
        public Composite(string name, Component[] components):base(name)
        {
            foreach(var component in components)
            {
                Add(component);
            }
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('_', Depth) + name);
            foreach (Component component in components)
            {
                component.Display(Depth+2);
            }
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
    public class Leaf : Component
    {
        public Leaf(string name):base (name) { }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int Depth)
        {
            Console.WriteLine(new string('_', Depth) + name);
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }

}
