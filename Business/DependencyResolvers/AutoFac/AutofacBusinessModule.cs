﻿using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;

namespace Business.DependencyResolvers.AutoFac
{
    public  class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
        } //Program.cs içine tanımlanır. Autofac ve autofac.extra.dynamic kurulmalı
    }
}
