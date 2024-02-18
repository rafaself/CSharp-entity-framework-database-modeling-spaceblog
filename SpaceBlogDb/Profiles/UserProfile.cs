using AutoMapper;
using SpaceBlogDb.Models;
using SpaceBlogDb.Models.DTOs;

namespace SpaceBlogDb.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>();
    }
}
