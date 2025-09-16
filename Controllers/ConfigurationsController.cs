using CredentialsAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CredentialsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        private readonly IAppSettingsService _appSettings;

        public ConfigurationsController(IAppSettingsService appSettings)
        {
            _appSettings = appSettings;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                AppName = _appSettings.ApplicationName,
                Environment = _appSettings.GetCurrentEnvironment(),
                DbConnection = _appSettings.DefaultConnectionString,
                CacheTimeout = _appSettings.CacheTimeout,
                FeatureXEnabled = _appSettings.EnableFeatureX
            });
        }
    }
}
