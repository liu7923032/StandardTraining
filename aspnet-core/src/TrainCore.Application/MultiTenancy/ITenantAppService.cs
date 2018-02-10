using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TrainCore.MultiTenancy.Dto;

namespace TrainCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
