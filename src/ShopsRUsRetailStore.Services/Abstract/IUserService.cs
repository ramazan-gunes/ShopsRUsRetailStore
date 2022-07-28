using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Entities.DTOs.User;
using ShopsRUsRetailStore.Entities.Filter.User;

namespace ShopsRUsRetailStore.Services.Abstract
{
    public interface IUserService
    {
        Task<ResponseDto<UserDto>> GetByIdAsync(string id);
        Task<ResponseDto<List<UserDto>>> GetListAsync(GetUserFilter filter);
        Task<ResponseDto<UserDto>> AddAsync(AddUserDto addUserDto);


    }
}
