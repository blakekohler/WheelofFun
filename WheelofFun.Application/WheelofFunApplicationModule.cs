using System.Reflection;
using Abp.Modules;

namespace WheelofFun
{
    [DependsOn(typeof(WheelofFunCoreModule))]
    public class WheelofFunApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
