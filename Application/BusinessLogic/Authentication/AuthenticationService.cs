using Application.Authentification;
using Application.Common.Interfaces;
using Application.Common.Models.Respones;
using Application.Common.Security;
using Application.Models;
using Application.Shared.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Application.BusinessLogic.Authentication
{
    public class AuthenticationService
    {
        private readonly IApplicationDbContext _contex;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public AuthenticationService(
            IApplicationDbContext context,
            IJwtProvider jwtProvider,
            IMapper mapper
        )
        {
            _contex = context;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<ServiceResult<UserLogin>> Login(UserLogin userLogin)
        {
            var user = _contex
                .Set<User>()
                .Where(u => u.UserName == userLogin.UserName && u.Active == true)
                .FirstOrDefault();
            if (user == null)
            {
                return new ServiceResult<UserLogin>
                {
                    ErrorMessage = "Wrong username or password!",
                    IsError = true,
                };
            }
            var passHash = new PasswordHasher(
                new OptionsWrapper<HashingOptions>(new HashingOptions())
            );
            if (!passHash.Check(passHash.Hash(userLogin.Password), user.Password).Verified)
            {
                return new ServiceResult<UserLogin>
                {
                    ErrorMessage = "Wrong username or password!",
                    IsError = true,
                };
            }
            UserLogin loggedUser = _mapper.Map<UserLogin>(user);
            loggedUser.Token = await _jwtProvider.GenerateTokenAsync(user);
            return new ServiceResult<UserLogin> { Result = loggedUser, IsError = false };
        }

        public async Task<ServiceResult<User>> Register(User request)
        {
            var user = _contex
                .Set<User>()
                .Where(u => u.UserName == request.UserName)
                .FirstOrDefault();
            if (user != null)
            {
                return new ServiceResult<User>
                {
                    ErrorMessage = "User already exists!",
                    IsError = true,
                };
            }

            var passHash = new PasswordHasher(
                new OptionsWrapper<HashingOptions>(new HashingOptions())
            );

            request.Password = passHash.Hash(request.Password);

            _contex.Set<User>().Add(request);

            await _contex.SaveChangesAsync();
            return new ServiceResult<User> { Result = user, IsError = false };
        }
    }
}
