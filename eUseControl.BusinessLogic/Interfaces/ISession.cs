﻿using eUseControl.Domain.Entities.Response;
using eUseControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eUseControl.BusinessLogic.Core.SessionApi;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ServiceResponse ValidateUserCredential(LoginData user);
        ServiceResponse ValidateUserRegister(RegisterData newUser);
        CookieResponse GenCookie(string nickname);
        User GetUserByCookie(string value);
    }
}
