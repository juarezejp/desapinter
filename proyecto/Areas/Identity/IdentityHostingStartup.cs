using System;


using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using proyecto.Areas.Identity.Data;

[assembly: HostingStartup(typeof(proyecto.Areas.Identity.IdentityHostingStartup))]
namespace proyecto.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<aeropuertoCollectionContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<aeropuertoCollectionContext>();
            });
        }
    }
}