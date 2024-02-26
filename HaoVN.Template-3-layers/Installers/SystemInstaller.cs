using HaoVN.Teamplate_3_layers.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HaoVN.Template_3_layers.Installers
{
    public class SystemInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddDbContext<StudentContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DBName");
                options.UseSqlServer(connectionString);
            });

        }
    }
}
