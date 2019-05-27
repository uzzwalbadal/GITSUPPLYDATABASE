using System.Threading.Tasks;
using Abp.Application.Services;
using supplyc.Authorization.Accounts.Dto;

namespace supplyc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
