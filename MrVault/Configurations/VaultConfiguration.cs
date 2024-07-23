namespace MrVault.Configurations;

public class VaultConfiguration
{
    public string BaseAddress { get; set; } = null!;
    public string MountPoint { get; set; } = null!;
    public string SecretLocationPath { get; set; } = null!;
    public TimeSpan PollingInterval { get; set; } = TimeSpan.FromMinutes(30);
    public string? Username { get; set; }
    public string? Password { get; set; }
}
