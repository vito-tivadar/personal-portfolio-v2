using System.Threading.RateLimiting;
using DotNetEnv;
using Microsoft.AspNetCore.RateLimiting;
using personal_portfolio_v2.Models;
using personal_portfolio_v2.Services;

namespace personal_portfolio_v2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Load .env as fallback — NoClobber skips vars already set in the environment
            Env.TraversePath().NoClobber().Load();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // SMTP settings from environment variables
            builder.Services.Configure<SmtpSettings>(options =>
            {
                options.Host = Environment.GetEnvironmentVariable("SMTP_HOST") ?? "";
                options.Port = int.TryParse(Environment.GetEnvironmentVariable("SMTP_PORT"), out var port) ? port : 587;
                options.Username = Environment.GetEnvironmentVariable("SMTP_USERNAME") ?? "";
                options.Password = Environment.GetEnvironmentVariable("SMTP_PASSWORD") ?? "";
                options.FromEmail = Environment.GetEnvironmentVariable("SMTP_FROM_EMAIL") ?? "";
                options.FromName = Environment.GetEnvironmentVariable("SMTP_FROM_NAME") ?? "Vito Tivadar";
                options.ToEmail = Environment.GetEnvironmentVariable("CONTACT_TO_EMAIL") ?? "";
            });

            builder.Services.AddTransient<IEmailService, EmailService>();

            // Rate limiting for contact API
            builder.Services.AddRateLimiter(options =>
            {
                options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
                options.AddFixedWindowLimiter("contact", limiter =>
                {
                    limiter.PermitLimit = 3;
                    limiter.Window = TimeSpan.FromMinutes(10);
                    limiter.QueueLimit = 0;
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseRateLimiter();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
