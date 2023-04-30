using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.User.Login;
using eUseControl.Domain.Entities.User.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            //return UserLoginAction(data);
            throw new NotImplementedException();
        }
        public URegisterResp UserRegister(URegisterData data)
        {
            //return UserRegisterAction(data);
            throw new NotImplementedException();
        }
    }
}
