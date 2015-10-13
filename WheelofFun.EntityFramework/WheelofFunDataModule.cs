using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using WheelofFun.EntityFramework;

namespace WheelofFun
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(WheelofFunCoreModule))]
    public class WheelofFunDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<WheelofFunDbContext>(null);
        }
    }
}
