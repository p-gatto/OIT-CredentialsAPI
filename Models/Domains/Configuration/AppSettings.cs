namespace CredentialsAPI.Models.Domains.Configuration
{
    public class AppSettings
    {
        public string? ApplicationName { get; set; }
        public ConnectionStrings? ConnectionStrings { get; set; }
        public EmailSettings? EmailSettings { get; set; }
        public int CacheTimeout { get; set; }
        public bool EnableFeatureX { get; set; }
        // Aggiungi altre proprietà in base alle tue esigenze
    }
}
