using DevFreela.API.Models;
using DevFreela.Application.Services.Implementations;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Infrastructure.Persistence;

namespace DevFreela.API.DependencyInjection
{
    public class SimpleInjector
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<DevFreelaDbContext>();

            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" });
        }
    }
}
