using Microsoft.Extensions.Configuration;
using MrVault.Configurations;

namespace MrVault;

public class VaultConfigurationSource : IConfigurationSource
{
    private readonly VaultConfiguration _config;


    public VaultConfigurationSource(VaultConfiguration config)
    {
        _config = config;
    }

    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new VaultConfigurationProvider(_config);
    }
}
