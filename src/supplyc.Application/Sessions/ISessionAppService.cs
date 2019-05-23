using System.Threading.Tasks;
using Abp.Application.Services;
using supplyc.Sessions.Dto;

namespace supplyc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
