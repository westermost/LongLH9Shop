﻿namespace LongLH9Shop.Data.Migrations
{
    using LongLH9Shop.Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LongLH9Shop.Data.LongLH9ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LongLH9ShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new LongLH9ShopDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new LongLH9ShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "admin",
                Email = "longlh9@fsoft.com.vn",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Le Hoang Long"
            };

            manager.Create(user, "123456*");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("longlh9@fsoft.com.vn");

            manager.AddToRole(adminUser.Id, "Admin");
            manager.AddToRole(adminUser.Id, "User");

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.
        }

        private void CreateProductCategorySample(LongLH9ShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh",Status=true },
                 new ProductCategory() { Name="Viễn thông",Alias="vien-thong",Status=true },
                  new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
                   new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham",Status=true }
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}