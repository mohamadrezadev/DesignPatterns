using Bridge.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstractions
{
    public abstract class Abstraction
    {
        private Implementor _implementor;
        public Abstraction()
        {
            _implementor = new ConcreatImplementor();
        }
        public  virtual void Function()
        {
            _implementor.Implementation();
        }
    }
    public class RefinedAbstraction : Abstraction
    {
        
    }
}
