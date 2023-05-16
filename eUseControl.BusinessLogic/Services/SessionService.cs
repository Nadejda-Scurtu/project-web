using eUseControl.Domain.Entities;
using System.Linq;

namespace eUseControl.BusinessLogic.Services
{
    public abstract class SessionService : BaseService
    {
        public static ServiceResponse<Session> GetByToken(string token)
        {
            return Success(DbContext.Sessions.FirstOrDefault(x => x.Token == token));
        }
    }
}
