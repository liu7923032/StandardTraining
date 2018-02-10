using System.Collections.Generic;
using TrainCore.Roles.Dto;
using TrainCore.Users.Dto;

namespace TrainCore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
