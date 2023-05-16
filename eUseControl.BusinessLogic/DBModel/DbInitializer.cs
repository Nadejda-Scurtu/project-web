using eUseControl.Domain.Entities;
using eUseControl.Domain.Enums;
using eUseControl.Helpers;
using System.Data.Entity;

namespace eUseControl.BusinessLogic.DBModel
{
    public class DbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Users.Add(new User
            {
                Name = "Test",
                Surname = "TestTest",
                Email = "test@test.com",
                PasswordHash = AuthHelper.GeneratePasswordHash("testtest"),
                Level = URole.Admin
            });

            context.Users.Add(new User
            {
                Name = "Test 2",
                Surname = "TestTest 2",
                Email = "test2@test.com",
                PasswordHash = AuthHelper.GeneratePasswordHash("testtest")
            });

            base.Seed(context);
        }
    }
}
