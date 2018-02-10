using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TrainCore.Controllers
{
    public abstract class TrainCoreControllerBase: AbpController
    {
        protected TrainCoreControllerBase()
        {
            LocalizationSourceName = TrainCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
