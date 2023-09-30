using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.App.Services.LoginServices
{
    public interface ILoginService
    {
        void Execute();

    }
    public class LoginService : ILoginService
    {
        public void Execute()
        {
            Action1();
        }
        public void Action1()
        {
            
        }
    }
}
