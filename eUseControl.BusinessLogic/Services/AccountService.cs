using eUseControl.Domain.Entities;
using eUseControl.Helpers;
using System;
using System.Data.Entity;
using System.Linq;

namespace eUseControl.BusinessLogic.Services
{
    public abstract class AccountService : BaseService
    {
        public struct LoginData
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string IpAddress { get; set; }
            public DateTime Time { get; set; }
        }

        public static ServiceResponse<Session> Login(LoginData data)
        {
            var passHash = AuthHelper.GeneratePasswordHash(data.Password);

            var user = DbContext.Users.FirstOrDefault(x => x.Email == data.Email && x.PasswordHash == passHash);
            if (user == null)
                return Failure<Session>("User with this pair not found");

            user.LoginIP = data.IpAddress;
            user.LoginDateTime = data.Time;
            DbContext.Entry(user).State = EntityState.Modified;

            var session = new Session()
            {
                Token = AuthHelper.GenerateSessionToken(user.Name),
                UserId = user.ID
            };

            DbContext.Sessions.Add(session);
            DbContext.SaveChanges();
            return Success(session);
        }

        public struct RegisterData
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string IpAddress { get; set; }
            public DateTime Time { get; set; }
        }

        public static ServiceResponse<User> Register(RegisterData data)
        {
            if(DbContext.Users.FirstOrDefault(x => x.Email == data.Email) != null)
                return Failure<User>("Account with this Email already exists.");

            var user = new User
            {
                Name = data.Name,
                Surname = data.Surname,
                Email = data.Email,
                PasswordHash = AuthHelper.GeneratePasswordHash(data.Password),
            };

            DbContext.Users.Add(user);
            DbContext.SaveChanges();
            return Success(user);
        }
    }
}
