using Abp.Web.Mvc.Views;

namespace WheelofFun.Web.Views
{
    public abstract class WheelofFunWebViewPageBase : WheelofFunWebViewPageBase<dynamic>
    {

    }

    public abstract class WheelofFunWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WheelofFunWebViewPageBase()
        {
            LocalizationSourceName = WheelofFunConsts.LocalizationSourceName;
        }
    }
}