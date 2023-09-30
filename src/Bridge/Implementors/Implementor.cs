using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementors
{
    public abstract class Implementor 
    {
        public abstract void Implementation();
       
    }
    public class ConcreatImplementor : Implementor
    {
        public override void Implementation()
        {
            Console.WriteLine("run ....... Implementors ......... ConcreatImplementor.Implementation()");
        }
    }
}
 