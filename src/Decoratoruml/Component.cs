﻿namespace Decoratoruml
{
    public abstract class Component
    {
        public abstract void Operation();
 
    }
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation() is Run.......!");
        }
    }


}
