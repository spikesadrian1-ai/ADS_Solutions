using demoInfrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace demoInfrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        //// TO DO: INSTALL IDENTITY CORE EXTENSION
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipleFactory;

        //// TO DO: INSTALL AUTHORIZATION SERVICE
        // OR MAKE AN INTERFACE
        //private readonly IAuthorizationService _authorizationService;


        //public IdentityService(
        //    UserManager<> userManager,
        //    IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory,
        //    IAuthorizationService authorizationService)
        //{

        //    _userManager = userManager;
        //    _userClaimsPrincipleFactory = userClaimsPrincipalFactory;
        //    _authorizationService = authorizationService;
        //}


        //public async Task<string> GetUserNameAsync(string userId)
        //{ 
        //    var user =await _userManager.Users.FirstAsync{ u => u.Id == userId}
        //}
    }
}
