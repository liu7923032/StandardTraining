using Abp.AspNetCore.Mvc.ViewComponents;

namespace TrainCore.Web.Views
{
    public abstract class TrainCoreViewComponent : AbpViewComponent
    {
        protected TrainCoreViewComponent()
        {
            LocalizationSourceName = TrainCoreConsts.LocalizationSourceName;
        }
    }
}
