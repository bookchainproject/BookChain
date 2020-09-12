using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using BookChain.Models.Worker;

namespace BookChain.Data
{
    public class BookChainUserManager : UserManager<Worker>
    {
        public BookChainUserManager(IUserStore<Worker> store, 
                                                IOptions<IdentityOptions> optionsAccessor, 
                                                IPasswordHasher<Worker> passwordHasher, 
                                                IEnumerable<IUserValidator<Worker>> userValidators, 
                                                IEnumerable<IPasswordValidator<Worker>> passwordValidators, 
                                                ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, 
                                                IServiceProvider services, ILogger<UserManager<Worker>> logger) : 
            base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }

}
