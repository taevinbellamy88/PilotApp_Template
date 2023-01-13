namespace PilotApp.Web.Api.StartUp.DependencyInjection
{
    public interface IConfigureDependencyInjection
    {
        void ConfigureServices(IServiceCollection services, IConfiguration configuration);
    }
}