using AutoMapper;
using HaoVN.Teamplate_3_layers.Infrastructure.Interfaces;
using HaoVN.Teamplate_3_layers.Infrastructure.Repository;
using HaoVN.Template_3_layers.Service.AutoMapperProfile;
using HaoVN.Template_3_layers.Service.Interfaces;
using HaoVN.Template_3_layers.Service.Service;

namespace HaoVN.Template_3_layers.Installers
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMapper>(sp =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new AutoMapperProfile());
                });
                return config.CreateMapper();
            });
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IStudentService, StudentService>();
        }
    }
}
