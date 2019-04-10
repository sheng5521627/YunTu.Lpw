using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using YunTu.Lpw.Authorization.Users;

namespace YunTu.Lpw.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
