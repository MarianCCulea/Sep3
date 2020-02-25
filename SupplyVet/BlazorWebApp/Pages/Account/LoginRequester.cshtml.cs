using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorWebApp.Model.Domain;
using BlazorWebApp.Shared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorWebApp.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        protected UserData userData = new UserData();

        public async Task<IActionResult> OnPostAsync(string username, string password)
        {

            User user = await userData.LoginUserAsync(username, password);
            // TODO get claims here by username from database.
            if (user.role==null)
                return LocalRedirect(Url.Content("~/login"));
            else
            {
                var claims = new List<Claim>{
                new Claim(ClaimTypes.Name, user.id+""),
                new Claim(ClaimTypes.NameIdentifier,username),
                new Claim("Password",user.password),
                new Claim("Role", user.role),
                new Claim("FullName", user.fullname),
                new Claim("Email",user.email),
                new Claim("VetId",user.vetid+""),
            };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return LocalRedirect(Url.Content("~/"));
            }
        }
    }
}