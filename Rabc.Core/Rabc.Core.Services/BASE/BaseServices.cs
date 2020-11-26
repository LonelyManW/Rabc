using Rabc.Core.IServices;
using Rabc.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rabc.Core.Services
{
    /// <summary>
    /// @lastway 服务层基类接口 
    /// </summary>
    /// <typeparam name="TEntity">实体类</typeparam>
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class, new()
    {
        public IBaseRepository<TEntity> BaseDal;//通过在子类的构造函数中注入，这里是基类，不用构造函数
    }
}
