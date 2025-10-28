using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Wasalni.Infrastructure.Interfaces;
using Wasalni.Infrastructure.Repositories;
using Wasalni_DataAccess.Data;
using Wasalni_Utility;

namespace Wasalni
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDbContext>();
            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
                options.LoginPath = $"/Identity/Account/Login";
            });
            builder.Services.AddHttpClient<AccountApiClient>()
    .ConfigurePrimaryHttpMessageHandler(() =>
        new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                Console.WriteLine("⚠️ SSL validation bypassed!");
                return true;
            }
        });
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
