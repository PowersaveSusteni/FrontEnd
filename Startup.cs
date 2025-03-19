using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Identity.Web;
using Microsoft.Graph;
using Kendo.Mvc;

namespace Susteni
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            this.WebHostEnvironment = webHostEnvironment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public class MySettings
        {
            public string Server { get; set; }
            public string Database { get; set; }
            public string Language { get; set; }
            public string WebserviceUrl { get; set; }
        }

        public static string WebRootPath { get; private set; }
        public static string StandardSprak = "";

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Unspecified;
                options.HandleSameSiteCookieCompatibility();
            });

            services.AddCors(corsOption => corsOption.AddPolicy(
                "ReportingRestPolicy",
                corsBuilder =>
                {
                    corsBuilder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                }));

            services.AddOptions();

            services.AddRazorPages();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    options.SerializerSettings.Formatting = Formatting.Indented;
                })
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.SuppressMapClientErrors = true;
                });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });

            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue;
            });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo> { new CultureInfo("de-DE"), new CultureInfo("no-NB") };

                options.DefaultRequestCulture = new RequestCulture("no-NB", "no-NB");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(480);
            });

            services.AddKendo(x => { x.IconType = IconType.Font; });

            services.AddOptions();
            services.Configure<MySettings>(Configuration.GetSection("MySettings"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".vds"] = "application/octet-stream";

            app.UseStaticFiles(new StaticFileOptions
            {
                ContentTypeProvider = provider
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSession();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors("ReportingRestPolicy");

            var supportedCultures = new[] { new CultureInfo("nb-NO"), new CultureInfo("de-DE") };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("nb-NO"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Content-Type", "application/json");
                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(env.ContentRootPath, "App_Data"));

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                   Path.Combine(Path.GetDirectoryName(
                       System.Reflection.Assembly.GetEntryAssembly().Location),
                       "TXTextControl.Web")),
                RequestPath = "/TXTextControl.Web"
            });

            app.UseWebSockets();
            app.UseMiddleware<TXTextControl.Web.WebSocketMiddleware>();
        }
    }
}
