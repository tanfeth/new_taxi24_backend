using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Entity;
using Taxi24.Core.IRepository;

namespace Taxi24.Infra.Handlers
{
    public class UserHandler : IUserHandler
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public UserHandler(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;

        }

        public int? GetUserId()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (!string.IsNullOrEmpty(userId))
            {
                return int.Parse(userId);
            }
            return null;
        }



        public string GetLanguage()
        {
            string lang = LanguageEnumName.Arabic;
            if (httpContextAccessor.HttpContext?.Request?.Headers != null)
            {
                httpContextAccessor.HttpContext?.Request?.Headers?.TryGetValue("culture", out var language);
                lang = language;
            }
            if (lang == null)
                lang = LanguageEnumName.Arabic;
            return lang;

        }
    }
}
