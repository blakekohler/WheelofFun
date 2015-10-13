using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace WheelofFun.EntityFramework.Repositories
{
    public abstract class WheelofFunRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<WheelofFunDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected WheelofFunRepositoryBase(IDbContextProvider<WheelofFunDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class WheelofFunRepositoryBase<TEntity> : WheelofFunRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected WheelofFunRepositoryBase(IDbContextProvider<WheelofFunDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
