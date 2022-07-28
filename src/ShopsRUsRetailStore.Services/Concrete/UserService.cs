using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ShopsRUsRetailStore.Core.DTOs.Result;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Entities.DTOs.User;
using ShopsRUsRetailStore.Entities.Filter.User;
using ShopsRUsRetailStore.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ShopsRUsRetailStore.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<ResponseDto<UserDto>> GetByIdAsync(string id)
        {

            var user = await _userManager.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (user == null)
                ResponseDto<UserDto>.Fail("User not found", 404, true);
            var userDto = _mapper.Map<User, UserDto>(user);
            return ResponseDto<UserDto>.Success(userDto, 200);
        }

        public async Task<ResponseDto<List<UserDto>>> GetListAsync(GetUserFilter filter)
        {
            var users = await _userManager.Users.Where(x => !filter.Type.HasValue || x.Type == filter.Type).ToListAsync();
            var mappedUsers = _mapper.Map<List<User>, List<UserDto>>(users);
            return ResponseDto<List<UserDto>>.Success(mappedUsers, 200);
        }

        public async Task<ResponseDto<UserDto>> AddAsync(AddUserDto addUserDto)
        {

            var user = new User
            {
                Email = addUserDto.Email,
                UserName = addUserDto.UserName,
                Type = addUserDto.Type,
                FirstName = addUserDto.FirstName,
                LastName = addUserDto.LastName,
                CreatedDate = DateTime.Now
            };

            try
            {
                var result = await _userManager.CreateAsync(user, addUserDto.Password);

                if (!result.Succeeded)
                {
                    var errors = result.Errors.Select(x => x.Description).ToList();
                    return ResponseDto<UserDto>.Fail(new ErrorDto(errors, true), 404);
                }
            }
            catch (Exception ex)
            {
                return ResponseDto<UserDto>.Fail("User could not be created", 404, false);
            }

            var mappedUser = _mapper.Map<UserDto>(user);


            return ResponseDto<UserDto>.Success( mappedUser, 200);


        }
    }
}
