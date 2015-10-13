using Abp.Application.Services;

namespace WheelofFun
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class WheelofFunAppServiceBase : ApplicationService
    {
        protected WheelofFunAppServiceBase()
        {
            LocalizationSourceName = WheelofFunConsts.LocalizationSourceName;
        }
    }
}