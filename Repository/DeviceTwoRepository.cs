public class DeviceTwoRepository : IDeviceTwoRepository
{
    public async Task<List<SomeInfo2>> SomethingOtherThanSomeData(Guid deviceId)
    {
        return new List<SomeInfo2>();
    }
}