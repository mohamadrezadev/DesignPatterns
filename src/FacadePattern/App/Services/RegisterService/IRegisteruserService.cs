using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.App.Services.RegisterService
{
    public  interface IRegisteruserService
    {
        void Execute();
    }
    public class RegisteruserService : IRegisteruserService
    {
        public void Execute()
        {
            Action1();
            Action2();
        }
        public void Action1() { }
        public void Action2() { }
    }
}
