using CredentialsAPI.Models.Domains.Configuration;

namespace CredentialsAPI.Repositories.Interfaces
{
    public interface IAppSettingsService
    {
        string ApplicationName { get; }
        string DefaultConnectionString { get; }
        string LoggingConnectionString { get; }
        EmailSettings EmailSettings { get; }
        int CacheTimeout { get; }
        bool EnableFeatureX { get; }
        string GetCurrentEnvironment();
    }
}
