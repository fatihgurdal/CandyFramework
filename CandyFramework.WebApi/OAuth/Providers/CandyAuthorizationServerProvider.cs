using CandyFramework.Core.Concrete.IoC;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace CandyFramework.WebApi.OAuth.Providers
{
    public class CandyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        // OAuthAuthorizationServerProvider sınıfının client erişimine izin verebilmek için ilgili ValidateClientAuthentication metotunu override ediyoruz.
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        // OAuthAuthorizationServerProvider sınıfının kaynak erişimine izin verebilmek için ilgili GrantResourceOwnerCredentials metotunu override ediyoruz.
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            // CORS ayarlarını set ediyoruz.
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            var dependencyContainer = DependencyContainer.Current;
            var userService = (BusinessLayer.Interface.IUserService)dependencyContainer.Resolve(typeof(BusinessLayer.Interface.IUserService));

            // Kullanıcının access_token alabilmesi için gerekli validation işlemlerini yapıyoruz.
            if (userService.UserNamePasswordControl(context.UserName, context.Password))
            {
                var userGroupService = (BusinessLayer.Interface.IUserGroupService)dependencyContainer.Resolve(typeof(BusinessLayer.Interface.IUserGroupService));
                var user = userService.GetUserByPassword(context.UserName, context.Password);
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                identity.AddClaim(new Claim("sub", context.UserName));
                identity.AddClaim(new Claim("role", user.UserGroupName));

                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Kullanıcı adı veya şifre yanlış.");
            }
        }
    }
}