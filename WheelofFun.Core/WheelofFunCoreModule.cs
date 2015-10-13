using System.Reflection;
using Abp.Modules;

namespace WheelofFun
{
    public class WheelofFunCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
