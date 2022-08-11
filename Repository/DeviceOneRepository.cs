public class DeviceOneRepository : IDeviceOneRepository
{
    public async Task<List<SomeInfo1>> SomeData(Guid deviceId)
    {
        return new List<SomeInfo1>();
    }
}