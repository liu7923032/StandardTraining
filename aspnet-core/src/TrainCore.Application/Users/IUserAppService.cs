using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TrainCore.Roles.Dto;
using TrainCore.Users.Dto;

namespace TrainCore.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
