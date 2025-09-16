using CredentialsAPI.Models.Domains.Configuration;
using CredentialsAPI.Repositories.Interfaces;
using Microsoft.Extensions.Options;

namespace CredentialsAPI.Repositories.Implementations
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly AppSettings _settings;
        private readonly IHostEnvironment _environment;

        public AppSettingsService(IOptions<AppSettings> settings, IHostEnvironment environment)
        {
            _settings = settings.Value;
            _environment = environment;
        }

        public string ApplicationName => _settings.ApplicationName!;
        public string DefaultConnectionString => _settings.ConnectionStrings!.DefaultConnection!;
        public string LoggingConnectionString => _settings.ConnectionStrings!.LoggingConnection!;
        public EmailSettings EmailSettings => _settings.EmailSettings!;
        public int CacheTimeout => _settings.CacheTimeout;
        public bool EnableFeatureX => _settings.EnableFeatureX;

        public string GetCurrentEnvironment()
        {
            return _environment.EnvironmentName;
        }
    }
}
