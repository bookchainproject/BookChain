using BookChain.Models.Worker;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookChain.Data
{
    public class BookChainSignInManager : SignInManager<Worker>
    {
        public BookChainSignInManager(UserManager<Worker> userManager,
                                                  IHttpContextAccessor contextAccessor,
                                                  IUserClaimsPrincipalFactory<Worker> claimsFactory,
                                                  IOptions<IdentityOptions> optionsAccessor,
                                                  ILogger<SignInManager<Worker>> logger,
                                                  IAuthenticationSchemeProvider schemes) :
            base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
        {
        }
    }
}
