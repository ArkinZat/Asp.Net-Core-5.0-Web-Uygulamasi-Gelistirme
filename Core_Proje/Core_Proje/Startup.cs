using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje
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
            services.AddDbContext<Context>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

			services.AddMvc();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(100);
                options.AccessDeniedPath = "/ErrorPage/Index/";
                options.LoginPath = "/Writer/Login/Index/";
            });


			services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IPortfolioService, PortfolioManager>();
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IToDoListService, ToDoListManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IWriterMessageService, WriterMessageManager>();
            services.AddScoped<IWriterUserService, WriterUserManager>();

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IMessageDal, EfMessageDal>();
            services.AddScoped<IPortfolioDal, EfPortfolioDal>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<ISkillDal, EfSkillDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMedia>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<IToDoListDal, EfToDoListDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IWriterMessageDal, EfWriterMessageDal>();
            services.AddScoped<IWriterUserDal, EfWriterUserDal>();
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

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Default}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
                );
            });


        }
    }
}
