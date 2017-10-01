using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldPay.Merchant.Genie.Infrastructure.Services;
using WorldPay.Merchant.Genie.Web.Utilities;

namespace WorldPay.Merchant.Genie.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class GenieController : Controller
    {
        private readonly IGenieUserService _genieUserService;
        private readonly IAuthentication _authentication;

        public GenieController(IGenieUserService genieUserService, IAuthentication authentication)
        {
            _genieUserService = genieUserService;
            _authentication = authentication;
        }
        //TODO: verifiy credentials in middleware and use IdentityServer as maangement
        [HttpPost]
        public async Task<IActionResult> GetProfile([FromBody]Token token)
        {
            if (_authentication.Verfiy(token))
            { 
                var reader = new TokenReader(token);
                var userProfile = await _genieUserService.GetAsync(reader.Read("userId"));
                return Json(userProfile);
            }
            return Unauthorized();
        }
        //mimic token provider behaviour
        [HttpPost]
        public async Task<IActionResult> Authorize([FromBody]Credentials credentials)
        {
            var token = await _authentication.Authorize(credentials);

            return Json(token);
        }
    }
}
