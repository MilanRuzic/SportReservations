using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Models
{
    public class UserLogin : IMapFrom<User>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get;    set; }
    }
}
