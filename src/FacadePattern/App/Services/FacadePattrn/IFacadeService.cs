using FacadePattern.App.Services.LoginServices;
using FacadePattern.App.Services.RegisterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.App.Services.FacadePattrn
{
    public interface IFacadeService
    {
        IRegisteruserService registeruserService { get; }
        ILoginService loginService { get; }
    }
    public class FacadeService : IFacadeService
    {
        private IRegisteruserService _registeruserService;
        public IRegisteruserService registeruserService { get
            {
                return _registeruserService=_registeruserService ?? new RegisteruserService();
            } 
        }
        private ILoginService _loginService;
        public ILoginService loginService
        {
            get
            {
                return _loginService = _loginService ?? new LoginService();
            }
        }
    }
}


//shold thi class register in di container in .net core