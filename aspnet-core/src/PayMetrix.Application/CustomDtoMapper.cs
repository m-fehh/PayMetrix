using Abp.AutoMapper;
using AutoMapper;
using PayMetrix.Authorization.Users;
using PayMetrix.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMetrix
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        { 
            configuration.CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
