﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mubasa.DataAccess.Data;

namespace Mubasa.Web.Installers
{
    public class DatabaseInstaller : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseMySQL(
                    configuration.GetConnectionString("Default")));

            services.AddIdentity<IdentityUser, IdentityRole>(config => { config.SignIn.RequireConfirmedEmail = false; })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI();
        }
    }
}
