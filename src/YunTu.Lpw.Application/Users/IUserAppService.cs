using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YunTu.Lpw.Roles.Dto;
using YunTu.Lpw.Users.Dto;

namespace YunTu.Lpw.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
