using Microsoft.Extensions.Configuration;
using MrVault.Configurations;

namespace MrVault;

public static class Registration
{
      public static IConfigurationBuilder AddApVaultSecurityManagment(this IConfigurationBuilder builder, Action<VaultConfiguration> configurator)
  {
      if (builder is null)
          throw new ArgumentNullException(nameof(builder));

      if (configurator is null)
          throw new ArgumentNullException(nameof(configurator));

      VaultConfiguration config = new();
      configurator(config);

      return builder.Add(new VaultConfigurationSource(config));
  }
}
