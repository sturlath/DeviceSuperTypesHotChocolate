public interface IDeviceOneRepository
{
    Task<List<SomeInfo1>> SomeData(Guid deviceId);
}