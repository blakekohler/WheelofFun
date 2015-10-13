using Abp.Web.Mvc.Controllers;

namespace WheelofFun.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class WheelofFunControllerBase : AbpController
    {
        protected WheelofFunControllerBase()
        {
            LocalizationSourceName = WheelofFunConsts.LocalizationSourceName;
        }
    }
}