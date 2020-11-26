using System;
using System.Collections.Generic;
using System.Text;

namespace Rabc.Core.Repository
{
    /// <summary>
    /// @lastway 基类仓储层
    /// </summary>
    /// <typeparam name="TEntity">实体类</typeparam>
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
    }
}
