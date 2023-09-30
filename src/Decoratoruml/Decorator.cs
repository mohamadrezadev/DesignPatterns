namespace Decoratoruml
{
    public abstract class Decorator : Component
    {
        private readonly Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }
        public override void Operation()
        {
            _component.Operation();
        }

    }
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            NewFeaure();
        }
        public void NewFeaure()
        {
            Console.WriteLine("ConcreteDecorator.newFeaure()");
        }
    }
}
