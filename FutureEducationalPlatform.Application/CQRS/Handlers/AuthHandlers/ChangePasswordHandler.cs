﻿using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordRequest, string>
    {
        private readonly IIdentityService _identityService;
        private readonly IUnitOfWork _unitOfWork;

        public ChangePasswordHandler(IIdentityService identityService, IUnitOfWork unitOfWork)
        {
            _identityService = identityService;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            var user =  await _unitOfWork.UserRepository.GetUserByRefreshTokenAsync(request.ChangePasswordDto.refreshToken);
            if (user == null || request.ChangePasswordDto.refreshToken == "")
                throw new EntityNotFoundException("User Not Found");
            await _identityService.ChangePassword(user,request.ChangePasswordDto.oldPassword, request.ChangePasswordDto.newPassword);
            return request.ChangePasswordDto.newPassword;
        }
    }
}
