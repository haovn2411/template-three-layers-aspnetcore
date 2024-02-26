namespace HaoVN.Template_3_layers.Installers
{
    public static class InstallerExtention
    {
        public static void InstallerServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installer = typeof(Program).Assembly.ExportedTypes.Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface
            && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();

            installer.ForEach(installer => installer.InstallServices(services, configuration));
        }
    }
}
