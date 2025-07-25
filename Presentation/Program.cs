using Infrastructure.DIConfig;
using Persistence.DatabaseConfig.Config;
namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSession();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDatabaseDependency(builder.Configuration);
            builder.Services.AddRepositories();
            builder.Services.AddIdentityConfig();
            builder.Services.AddApplication();
            builder.Services.AddApplicationAutoMapper();
            builder.Services.AddOtherService(builder.Configuration);
            builder.Services.InitialValueConfig(builder.Configuration);
            builder.Services.ConfigureHttpClient(builder.Configuration);
            builder.Services.AddSignalR();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthorization();

			app.UseSession();

			app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
