using System.Threading.Tasks;
using Abp.Application.Services;
using TrainCore.Sessions.Dto;

namespace TrainCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
