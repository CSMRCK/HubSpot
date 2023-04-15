using HubSpotAuth.Models;
using HubSpotAuth.Repositories;
using HubSpotAuth.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HubSpotAuth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("ContactsDb");

            // Add services to the container.
            builder.Services.AddAuthorization();
            builder.Services.AddDbContext<ContactsDbContext>(x => x.UseSqlServer(connectionString));

            builder.Services.AddScoped<IHubSpotService, HubSpotService>();
            builder.Services.AddScoped<IContactRepository, ContactRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.Run();
        }
    }
}