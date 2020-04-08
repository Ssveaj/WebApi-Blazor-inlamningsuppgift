using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface IAuthService
    {
        public Task<LoginResponseModel> LoginAsync(LoginModel model);
        public Task<bool> RegisterAsync(RegisterModel model);
    }
}
