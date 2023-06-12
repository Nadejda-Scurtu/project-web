using eUseControl.Domain.Entities;
using System.Linq;

namespace eUseControl.BusinessLogic.Services
{
    public class SessionService : BaseService
    {
        public ServiceResponse<SDbModel> GetByToken(string token)
        {
            return Success(DbContext.Sessions.FirstOrDefault(x => x.Token == token));
        }
    }
}
