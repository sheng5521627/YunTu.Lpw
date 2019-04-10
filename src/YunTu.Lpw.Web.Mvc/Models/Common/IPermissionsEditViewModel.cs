using System.Collections.Generic;
using YunTu.Lpw.Roles.Dto;

namespace YunTu.Lpw.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}