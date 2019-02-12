using System;
using DevUniversity.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DevUniversity.Areas.Identity.IdentityHostingStartup))]
namespace DevUniversity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DevUniversityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DevUniversityContextConnection")));

                //services.AddDefaultIdentity<IdentityUser>()
                 //   .AddEntityFrameworkStores<DevUniversityContext>();
            });
        }
    }
}