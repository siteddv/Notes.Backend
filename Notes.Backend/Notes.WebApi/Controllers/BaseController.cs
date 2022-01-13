﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace Notes.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService(typeof(IMediator)) as IMediator;

        internal Guid UserId => User.Identity.IsAuthenticated
            ? Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value)
            : Guid.Empty;
    }
}