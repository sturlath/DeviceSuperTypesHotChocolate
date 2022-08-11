public class DeviceTwoRepository : IDeviceTwoRepository
{
    public async Task<List<SomeInfo2>> SomethingOtherThanSomeData(Guid deviceId)
    {
        var data = new List<SomeInfo2>();
        data.Add(new SomeInfo2() { Age = 20, Name = "Another Brilliant Device Name" });

        return data;
    }
}