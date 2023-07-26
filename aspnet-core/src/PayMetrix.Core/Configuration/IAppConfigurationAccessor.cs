using Microsoft.Extensions.Configuration;

namespace PayMetrix.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
