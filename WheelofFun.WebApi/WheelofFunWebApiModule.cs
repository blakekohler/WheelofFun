using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace WheelofFun
{
    [DependsOn(typeof(AbpWebApiModule), typeof(WheelofFunApplicationModule))]
    public class WheelofFunWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(WheelofFunApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
