using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gljivar.Models;
using Gljivar.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using My.Model.DatabaseConnector;

namespace Gljivar
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GljivarContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options => { options.LoginPath = "/Login"; });


            services.AddScoped<IDbFactory, DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IGljivaService, GljivaService>();
            services.AddScoped<IObjavaService, ObjavaService>();
            services.AddScoped<IKomentarService, KomentarService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBiljeskaService, BiljeskaService>();
            services.AddScoped<IGljivarDrustvoService, GljivarDrustvoService>();
            services.AddScoped<IDogadajiService, DogadajiService>();
            services.AddScoped<IMjestoService, MjestoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Objava}/{action=Index}/{id?}");
            });
        }
    }
}
