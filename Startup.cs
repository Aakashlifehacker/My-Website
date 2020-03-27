using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Zachariasz_Jankowski.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Hangfire;
using Hangfire.SQLite;
using System.Net;


namespace Zachariasz_Jankowski
{
    public class Startup
    {

        private DataDbContext _context;
        public Startup(IConfiguration configuration)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            optionsBuilder.UseSqlite("Data Source=data.db");
            _context = new DataDbContext(optionsBuilder.Options);
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<DataDbContext>(options =>
                options.UseSqlite("Data Source=data.db"));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
           services.AddRazorPages();


            services.AddHangfire(x => x.UseSQLiteStorage("Data Source=hangfire.db;"));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseHangfireServer();

            RecurringJob.AddOrUpdate(
            () => UpdateDates(),
            Cron.Hourly);

            if (env.IsDevelopment())
            {
                app.UseHangfireDashboard("/hangfire");
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseHangfireDashboard("/hangfire");
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

                //app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=feed}/{action=index}/{id?}");
                endpoints.MapRazorPages();
            });
        }

        public async Task UpdateDates()
        {

            var projects = await _context.project.ToArrayAsync();
            for (int i = 0; i < projects.Length; i++) {

                string result;
                int first = 0;

                using (WebClient client = new WebClient())
                {result = client.DownloadString(projects[i].remoteAddress);}

                if (result.Contains("relative-time datetime="))
                first = result.IndexOf("relative-time datetime=") + "relative-time datetime=".Length + 1;

                DateTime lastcommit = Convert.ToDateTime(result.Substring(first, 10));
                Console.WriteLine(result.Substring(first, 10));
                DateTime today = DateTime.Now;
                projects[i].daysAgo = (int)(today - lastcommit).TotalDays;
                _context.SaveChanges();
            }
            

        }
    }
}
