using Autofac;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Rabc.Core.Repository;

namespace Rabc.Core.Extensions
{
    /// <summary>
    /// @autofac依赖注入
    /// </summary>
    public class AutofacModuleRegister : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;

            #region 带有接口的服务层注入
            var servicesDllFile = Path.Combine(basePath, "Rabc.Core.Services.dll");
            var repositoryDllFile = Path.Combine(basePath, "Rabc.Core.Repository.dll");

            if (!File.Exists(servicesDllFile) && !File.Exists(repositoryDllFile))
            {
                var msg = "Repository.dll和service.dll 丢失，因为项目解耦了，所以需要先F6编译，再F5运行，请检查 bin 文件夹，并拷贝。";
                //log.Error(msg);
                throw new Exception(msg);
            }

            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();//注册仓储

            //获取Services.dll 程序集 并注册
            var assemblyServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblyServices)
                .AsImplementedInterfaces()
                .InstancePerDependency()
                .EnableInterfaceInterceptors(); //引用Autofac.Extras.DynamicProxy;

            //获取Repository.dll 程序集 并注册
            var assemblyRepository = Assembly.LoadFrom(repositoryDllFile);
            builder.RegisterAssemblyTypes(assemblyRepository)
                .AsImplementedInterfaces()
                .InstancePerDependency();
            #endregion
        }
    }
}
