﻿using eUseControl.Domain.Entities.User.Login;
using eUseControl.Domain.Entities.User.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        URegisterResp UserRegister(URegisterData data);
    }
}