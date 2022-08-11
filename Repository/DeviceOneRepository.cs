public class DeviceOneRepository : IDeviceOneRepository
{
    public async Task<List<SomeInfo1>> SomeData(Guid deviceId)
    {
        var data = new List<SomeInfo1>();
        data.Add(new SomeInfo1() { Count = 10, Name = "Brilliant Device Name" });

        return data;
    }
}