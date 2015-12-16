using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using AutomatedHouse.Data;
using AutomatedHouse.Data.Repositories;
using AutomatedHouse.DataContracts;
using AutomatedHouse.ServiceContracts;
using AutomatedHouse.Services;

namespace AutomatedHouse.WebApi
{
    public class AutofacConfig
    {
        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<AutomatedHouseDbContext>().As<DbContext>().InstancePerLifetimeScope();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<AccessoryService>().As<IAccessoryService>().InstancePerLifetimeScope();
            builder.RegisterType<HouseService>().As<IHouseService>().InstancePerLifetimeScope();
            builder.RegisterType<RoomService>().As<IRoomService>().InstancePerLifetimeScope();
            builder.RegisterType<SensorService>().As<ISensorService>().InstancePerLifetimeScope();

            builder.RegisterType<AccessoryRepository>().As<IAccessoryRepository>().InstancePerLifetimeScope();
            builder.RegisterType<HouseRepository>().As<IHouseRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RoomRepository>().As<IRoomRepository>().InstancePerLifetimeScope();
            builder.RegisterType<SensorRepository>().As<ISensorRepository>().InstancePerLifetimeScope();

            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}