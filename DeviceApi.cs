using Refit;

public interface DeviceApi
{
    [Post("/api/devices")]
    Task<string> GetDeviceInformationAsync(
    [Body] QueryDto query,
    [Header("accept-version")] string version,
    CancellationToken cancellationToken);
}