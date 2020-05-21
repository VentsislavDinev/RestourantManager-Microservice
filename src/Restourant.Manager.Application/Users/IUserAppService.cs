using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Restourant.Manager.Roles.Dto;
using Restourant.Manager.Users.Dto;

namespace Restourant.Manager.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
