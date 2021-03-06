﻿using Autofac;
using SimbaCapital.Model;
using SimbaCapital.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimbaCapital.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(SimbaCapitalContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}   