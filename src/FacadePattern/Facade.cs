using FacadePattern.subsystem1;
using FacadePattern.subsystem2;
using FacadePattern.subsystem3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Facade
    {
        public void dosomething()
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();

            class1.Action1();
            class2.Action2();
            class3.Action3();
        }
    }
}
