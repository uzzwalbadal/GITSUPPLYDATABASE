using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace supplyc.Controllers
{
    public abstract class supplycControllerBase: AbpController
    {
        protected supplycControllerBase()
        {
            LocalizationSourceName = supplycConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
